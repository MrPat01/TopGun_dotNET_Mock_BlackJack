using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translator.Core.Filter;
using Translator.Core.Models;

namespace Translator.Core.Services
{
    public class DictionaryService : Repository<Dictionary>, Translator.Core.IServices.IDictionaryService
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
            var query = GetAll().Where(x => x.VN == Input).FirstOrDefault();
            return query;
        }
        public Dictionary TranslateJP2VN(string Input)
        {
            var query = GetAll().Where(x => x.JP == Input).FirstOrDefault();
            return query;
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
    }
}
