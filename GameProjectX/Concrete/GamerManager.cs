using GameProjectX.Abstract;
using GameProjectX.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectX.Concrete
{
    // MicroService
    class GamerManager : IGamerService
    { // İş katmanı için Manager
        // Bir Manager sınıfının içerisinde başka bir manager sınıfı kullanılacaksa asla newleme!
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        { // Bağımlılık yaratılır, doğrulama servisi kullanılacak demektir.
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("{0} {1} is registered!", gamer.FirstName, gamer.LastName);
            }
            else
            {
                Console.WriteLine("Verification failed!");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("{0} {1} is deleted!", gamer.FirstName, gamer.LastName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("{0} {1} is updated!", gamer.FirstName, gamer.LastName);
        }
    }
}
