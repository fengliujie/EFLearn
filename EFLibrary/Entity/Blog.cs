using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;

namespace EFLibrary.Entity
{
    public class Blog:BaseEntity
    {
        [Required]
        [StringLength(100,ErrorMessage ="字符串不能超过100个字符")]
        [Url]
        public string Url { get; set; }
        internal string _Tags { get; set; }
        public string Tags //string[]
        {
            get { return _Tags == null ? null :_Tags ; }
            //JsonConvert.DeserializeObject<string[]>(_Tags)
            set { _Tags = JsonConvert.SerializeObject(value); }

        }
        //internal string _Owner { get; set; }
        //public Person Owner
        //{
        //    get { return (_Owner == null) ? null : JsonConvert.DeserializeObject<Person>(this._Owner); }
        //    set { _Owner = JsonConvert.SerializeObject(value); }
        //}

        public string _Owner { get; set; }

        public Person Owner
        {
            get { return (_Owner == null) ? null : JsonConvert.DeserializeObject<Person>(this._Owner); }
            set { _Owner = JsonConvert.SerializeObject(value); }
        }
        public virtual ICollection<Post> Posts { get; set; }
      
    }
}
