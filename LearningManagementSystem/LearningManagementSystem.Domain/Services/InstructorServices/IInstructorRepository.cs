using LearningManagementSystem.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.Domain.Services.InstructorServices
{
    public interface IInstructorRepository
    {
        InstructorViewModels CreateInstructor(InstructorViewModels reqModel);
    }
}
