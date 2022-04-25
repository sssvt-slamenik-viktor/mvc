using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace PetEShopWebMVC.BusinessObjects
{



    [Table("PE_USER")]
    public class User
    {



        [Key]
        [Column("ID")]
        public int ID { get; set; }

        [Column("USERNAME")]
        public string Username { get; set; }

        [Column("EMAIL")]
        public string Email { get; set; }



        public User(string username, string email)
        {
            this.Username = username;
            this.Email = email;
        }



        public User()
        {
        }



    }



}
