using System;
using System.Linq;

namespace WaterProject.Models
{
    public class EFCharityRepository: ICharityRepository
    {
        private CharityDBContext _context;
        //Constructor
        public EFCharityRepository (CharityDBContext context)
        {
            _context = context;
        }
        public IQueryable<Project> Projects => _context.Projects;
    }
}
