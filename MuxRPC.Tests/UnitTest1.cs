using System;
using MuxRPC;
using Xunit;

namespace MuxRPCTest {
    public class UnitTest1 {
        [Fact]
        public void Test1 () {
            var muxRPC = new Boom();
            Console.WriteLine(muxRPC.SayHello());
        }
    }
}