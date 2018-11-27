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
        public DictionaryService(TranslatorContext dbContext, IServices.ITranslateFailService ITranslateFailService) : base(dbContext)
        {
            _ITranslateFailService = ITranslateFailService;
        }
        public Dictionary Muti_Condition(List<DictionaryFilter> filter)
        {
            var query = GetAll();
            foreach (var item in filter)
            {

            }
            var model = query.FirstOrDefault();
            return model;
        }
        public Dictionary TranslateVN2JP(string Input)
        {
            var model = GetAll().Where(x => x.VN == Input).FirstOrDefault();
            if (model != null)
                return model;
            else
            {
                _ITranslateFailService.AddNew(new TranslateFail { Text = Input, typeId = TranslateType.Vn2Jp });
                return new Translator.Core.Models.Dictionary();
            }
        }
        public Dictionary TranslateJP2VN(string Input)
        {
            var model = GetAll().Where(x => x.JP == Input).FirstOrDefault();
            if (model != null)
                return model;
            else
            {
                _ITranslateFailService.AddNew(new TranslateFail { Text = Input, typeId = TranslateType.Jp2Vn });
                return new Translator.Core.Models.Dictionary();
            }
        }

        public Dictionary Translate(string Input, int type)
        {
            Dictionary model = new Dictionary();
            switch (type)
            {
                case 1:
                    model = TranslateVN2JP(Input);
                    break;
                case 2:
                    model = TranslateJP2VN(Input);
                    break;
                default:
                    break;
            }
            return model;
        }

        public string TranslateText(string text, TranslateType type)
        {
            switch (type)
            {
                case TranslateType.Jp2Vn:
                    return TranslateJP2VN(text)?.VN ?? text;
                case TranslateType.Vn2Jp:
                    return TranslateVN2JP(text)?.JP ?? text;
                default:
                    return text;
            }
        }
    }
}
