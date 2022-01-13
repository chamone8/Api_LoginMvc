using System;
using System.ComponentModel.DataAnnotations;

namespace Api_LoginMvc.Model.Interface
{
    public class IModelBase
    {
        [Key]
        public Guid Id { get; protected set; }
        public DateTime Created { get; protected set; }
        public DateTime Modified { get; protected set; }
        public DateTime Last_login { get; protected set; }
    }
}
