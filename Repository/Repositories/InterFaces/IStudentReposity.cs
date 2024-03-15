using Course_project.Models;
using Service.Services.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Repository.Repositories.InterFaces
{
    public interface IStudentReposity : IBaseRepositories<Student>
    {

        Student GetByAge(int age);
        Student GetStudentByGroupId(int? id);
        
    }

   
    
