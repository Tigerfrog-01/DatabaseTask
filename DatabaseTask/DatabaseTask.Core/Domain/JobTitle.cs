using System.ComponentModel.DataAnnotations;


namespace DatabaseTask.Core.Domain
{
    public class JobTitle
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }


       
       
     
    }




    

   

}

