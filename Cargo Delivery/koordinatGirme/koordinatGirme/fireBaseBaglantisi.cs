
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;



namespace koordinatGirme
{
    class firebasebaglanti
    {
        public IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "A4ybYrYrdBx3KRUlJj8ADnQ0XYg3EqtkwKzLklzS",
            BasePath = "https://maps-576fd-default-rtdb.firebaseio.com/"
        };

        public IFirebaseClient client;
        public FirebaseResponse response;
      
    }
    

}
