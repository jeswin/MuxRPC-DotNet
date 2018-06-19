using System;
using muxrpc;
using Xunit;

namespace muxrpc_test {
    public class UnitTest1 {
        [Fact]
        public void Test1 () {
            var muxrpc = new MuxRPC();
            Console.WriteLine(muxrpc.SayHello());
        }
    }
}