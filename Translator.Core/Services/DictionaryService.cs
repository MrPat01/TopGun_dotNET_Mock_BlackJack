using System.Collections.Generic;
using System.Linq;
using Translator.Core.Common;
using Translator.Core.Filter;
using Translator.Core.Models;

namespace Translator.Core.Services
{
    public class DictionaryService : Repository<Dictionary>, IServices.IDictionaryService
    {
        IServices.ITranslateFailService _ITranslateFailService;
        public DictionaryService(TranslatorContext dbContext, IServices.ITranslateFailService translateFailService) : base(dbContext)
        {
            _ITranslateFailService = translateFailService;
        }
        public Dictionary Muti_Condition(List<DictionaryFilter> filter)
        {
            var query = GetAll();
            var model = query.FirstOrDefault();
            return model;
        }
        public Dictionary TranslateVn2Jp(string input)
        {
            var model = GetAll().Where(x => x.VN == input).FirstOrDefault();
            if (model != null)
                return model;
            else
            {
                _ITranslateFailService.AddNew(new TranslateFail { Text = input, typeId = TranslateType.Vn2Jp });
                return new Dictionary();
            }
        }
        public Dictionary TranslateJp2Vn(string input)
        {
            var model = GetAll().Where(x => x.JP == input).FirstOrDefault();
            if (model != null)
                return model;
            else
            {
                _ITranslateFailService.AddNew(new TranslateFail { Text = input, typeId = TranslateType.Jp2Vn });
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
                    return TranslateJp2Vn(text)?.VN ?? text;
                case TranslateType.Vn2Jp:
                    return TranslateVn2Jp(text)?.JP ?? text;
                default:
                    return text;
            }
        }
    }
}
