using ProtoBuf;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Data
{
    [ProtoContract]
    public class Account
    {
        [ProtoMember(1)]
        public int Id { get; set; }

        [Required]
        [ProtoMember(2, DataFormat = DataFormat.WellKnown)]
        public DateTime Created { get; set; }

        [Required]
        [ProtoMember(3, DataFormat = DataFormat.WellKnown)]
        public DateTime LastChanged { get; set; }

        [Required]
        [ProtoMember(4)]
        public string Email { get; set; } = null!;

        [Required]
        [ProtoMember(5)]
        public string MyIdentityName { get; set; } = null!;
    }
}
