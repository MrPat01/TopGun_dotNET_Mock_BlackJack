using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Translator.Core.IServices;
using Translator.Core.Models;

namespace Translator.Core.Services
{
    public class FieldService : IFieldService
    {
        private IRepository<Field> _repository;
        public FieldService(IRepository<Field> repository)
        {
            _repository = repository;
        }

        public List<Field> GetAll()
        {
            return _repository.GetAll().ToList();
        }
    }
}
