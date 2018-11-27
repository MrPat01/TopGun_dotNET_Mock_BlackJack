using System.Collections.Generic;
using Translator.Core.Models;

namespace Translator.Core.IServices
{
    public interface IFieldService
    {
        List<Field> GetAll();
    }
}
