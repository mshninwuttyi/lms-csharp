using LearningManagementSystem.DataBase.Data;
using LearningManagementSystem.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningManagementSystem.DataBase.Models;

namespace LearningManagementSystem.Domain.Services.InstructorServices
{
    public class InstructorRepository : IInstructorRepository
    {
        private readonly AppDbContext _db;

        public InstructorRepository(AppDbContext db)
        {
            _db = db;
        }

        public InstructorViewModels CreateInstructor(InstructorViewModels reqModel)
        {
            var instrUserModel = UsersMapping(reqModel);

            var model = _db.Users.Add(instrUserModel);
            _db.SaveChanges();

            int userId = instrUserModel.id;

            var instrModel = InstructorMapping(reqModel, userId);
            var result = _db.Instructors.Add(instrModel);
            _db.SaveChanges();
            return reqModel;
        }





        private static TblUsers UsersMapping(InstructorViewModels reqModel)
        {
            return new TblUsers
            {
                //id = Guid.NewGuid(), 
                //id = 0,
                username = reqModel.username,
                email = reqModel.email,
                password = reqModel.password,
                phone = reqModel.phone,
                dob = reqModel.dob,
                address = reqModel.address,
                profile_photo = reqModel.profile_photo,
                role_id = reqModel.role_id,
                is_available = reqModel.is_available,
                created_at = reqModel.created_at,
                updated_at = reqModel.updated_at,
                isDeleted = false
            };
        }

        private static TblInstructors InstructorMapping(InstructorViewModels instructor, int userId)
        {
            return new TblInstructors
            {
                //id = Guid.NewGuid(), 
                user_id = userId,
                nrc = instructor.nrc,
                edu_background = instructor.edu_background,
                created_at = instructor.created_at,
                updated_at = instructor.updated_at
            };
        }
    }
}
