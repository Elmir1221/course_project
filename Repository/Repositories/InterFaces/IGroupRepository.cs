using Course_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.InterFaces
{
    public interface IGroupRepository : IBaseRepositories<Group>
    {
      
        List<Group> GetGroupsByTeacher(string teacher);
        List<Group> GetGroupsByTRoom(string room);
        List<Group> GetAllGroups(int? id);
        List<Group> GetAllStudents(string data);
       
        Group GetGroupbyId(int? id);


    }
}
