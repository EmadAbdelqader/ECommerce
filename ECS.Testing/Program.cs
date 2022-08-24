using ECS.Business;
using ECS.DataAccess;

UserRepo userRepo = new UserRepo();

//User _user = new User() {

//    FirstName = "Rami",
//    LastName = "Emad",
//    IsDeleted = false,
//    Type = 1,
//    CreatedBy = 1,
//    CreatedOn = DateTime.Now,
//    Email = "Rami@gmaill.com",
//    Status = 1,
//    UpdatedBy = 1,
//    UpdatedOn = DateTime.Now

//};

//// Save
//int userId = userRepo.Save(_user);


//// GetAll
//var usersList = userRepo.GetAll();



//// GetUserById
//var user = userRepo.GetUser(2);



//// GetFullNames
//var fullNames = userRepo.GetFullNames();

//User updatedUser = new User()
//{
//    Id = 4,
//    FirstName = "Yazeed",
//    LastName = "Ahmad",
//    Email = "em@ex.com"
//};


//userRepo.Update(updatedUser);

//userRepo.Delete(userRepo.GetUser(4));

userRepo.Delete(6);


Console.ReadKey();