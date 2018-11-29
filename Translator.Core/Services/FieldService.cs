using System.Collections.Generic;
using System.Linq;
using Translator.Core.IServices;
using Translator.Core.Models;

namespace Translator.Core.Services
{
    public class FieldService : IFieldService
    {
        private readonly IRepository<Field> _repository;
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
