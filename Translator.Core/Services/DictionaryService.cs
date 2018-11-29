using System.Linq;
using Translator.Core.Common;
using Translator.Core.Models;

namespace Translator.Core.Services
{
    public class DictionaryService : Repository<Dictionary>, IServices.IDictionaryService
    {
        private readonly IServices.ITranslateFailService _iTranslateFailService;
        public DictionaryService(TranslatorContext dbContext, IServices.ITranslateFailService translateFailService) : base(dbContext)
        {
            _iTranslateFailService = translateFailService;
        }
/*
        public Dictionary Multiple_Condition(List<DictionaryFilter> filter)
        {
            var query = GetAll();
            var model = query.FirstOrDefault();
            return model;
        }
*/
        public Dictionary TranslateVn2Jp(string input)
        {
            var model = GetAll().FirstOrDefault(x => x.Vn == input);
            if (model != null)
                return model;
            else
            {
                _iTranslateFailService.AddNew(new TranslateFail { Text = input, TypeId = TranslateType.Vn2Jp });
                return new Dictionary();
            }
        }
        public Dictionary TranslateJp2Vn(string input)
        {
            var model = GetAll().FirstOrDefault(x => x.Jp == input);
            if (model != null)
                return model;
            else
            {
                _iTranslateFailService.AddNew(new TranslateFail { Text = input, TypeId = TranslateType.Jp2Vn });
                return new Dictionary();
            }
        }

        public Dictionary Translate(string input, int type)
        {
            Dictionary model = new Dictionary();
            switch (type)
            {
                case 1:
                    model = TranslateVn2Jp(input);
                    break;
                case 2:
                    model = TranslateJp2Vn(input);
                    break;
            }
            return model;
        }

        public string TranslateText(string text, TranslateType type)
        {
            switch (type)
            {
                case TranslateType.Jp2Vn:
                    return TranslateJp2Vn(text)?.Vn ?? text;
                case TranslateType.Vn2Jp:
                    return TranslateVn2Jp(text)?.Jp ?? text;
                default:
                    return text;
            }
        }
    }
}
