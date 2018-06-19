using System;

namespace MuxRPC {
    public class Boom {
        public string SayHello () {
            throw new Exception("That did not work.");
            return "Hello world";
        }
    }
}