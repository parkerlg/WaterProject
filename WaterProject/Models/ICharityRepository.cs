using System;
using System.Linq;

namespace WaterProject.Models
{
    public interface ICharityRepository
    {
        IQueryable<Project> Projects { get; }
    }
}
