using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcLamarelle.Models
{

  public class Contact
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ID { get; set; }
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
  }

  public class ContactsDBContext : DbContext
  {
    public ContactsDBContext() : base("DefaultConnection") {}

    public DbSet<Contact> Contacts { get; set; }
  }
}