using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace PetEShopWebMVC.BusinessObjects
{



    [Table("PE_PERSON")]
    public class Person
    {



        [Key]
        [Column("ID")]
        public int ID { get; set; }

        //[Required]
        [Column("NAME")]
        public string Name { get; set; }

        //[Required]
        //[Range(1, 120)]
        [Column("AGE")]
        public int Age { get; set; }



        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }



        public Person()
        {
        }



    }



}
