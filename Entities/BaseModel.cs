using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities;

public class BaseModel
{
    public Guid Id { get; set; }
    public required string Title { get; set; }
    public DateTime DataCreated { get; set; }= DateTime.Now;
    public bool IsActive { get; set; }=true;
    public bool IsDeleted { get; set; }=false;

}
