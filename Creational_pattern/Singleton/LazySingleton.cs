using System;

namespace Singleton
{
    public class LazySingleton
    {
        private static Lazy<LazySingleton> lazy = new Lazy<LazySingleton>( () =>{
            return new LazySingleton();
        });

        public static LazySingleton Instance => lazy.Value;

        private LazySingleton(){
            
        }
    }
}