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
    public class ConfigPathService : Repository<ConfigPath>,IConfigPathService
    {
        public ConfigPathService(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
