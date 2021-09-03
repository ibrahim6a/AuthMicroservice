

namespace AuthMicroservice.Models {

    public enum UserStatus {
        Admin,
        User,
        Approved,
        Pending,
        Declined
    }

    public class User {
        
        public int Id { get; set; }
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        public string Email { get; set; }
        public string EncryptedPassword { get; set; }

        public UserStatus Status { get; set; }
        // public enum Status {
        //     Admin,
        //     User,
        //     Pending,
        //     Approved,
        //     Declined
        // }
    }
}