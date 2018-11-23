using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translator.Core.Common;
using Translator.Core.Filter;
using Translator.Core.Models;

namespace Translator.Core.Services
{
    public class DictionaryService : Repository<Dictionary>, IServices.IDictionaryService
    {
        public DictionaryService(TranslatorContext dbContext) : base(dbContext)
        {
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
            Dictionary model = new Dictionary();
            model = GetAll().Where(x => x.VN == Input).FirstOrDefault();
            return model;
        }
        public Dictionary TranslateJP2VN(string Input)
        {
            Dictionary model = new Dictionary();
            model = GetAll().Where(x => x.JP == Input).FirstOrDefault();
            return model;
        }

        public Dictionary Translate(string Input, int type)
        {
            Dictionary model = new Dictionary();
            switch(type)
            {
                case 1:
                    model = TranslateVN2JP(Input);
                    break;
                case 2:
                    model = TranslateJP2VN(Input);
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
