using System;
using System.Text;
using System.Collections.Generic;
using Iesi.Collections.Generic;

namespace Siska.Data.Dto.Pos {
    
    public class RoleDto {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public UserDto InsertBy { get; set; }
        public System.DateTime InsertDate { get; set; }
        public UserDto UpdateBy { get; set; }
        public System.Nullable<System.DateTime> UpdateDate { get; set; }
        public bool RecordStatus { get; set; }

        public ICollection<UserDto> Users { get; set; }

        public RoleDto()
        {
            Users = new HashedSet<UserDto>();
        }
    }
}