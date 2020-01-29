var edge = require('edge-js');

// TESTED WITH Node.js v8.9.0

// Uncomment this and change reference dll to make it work work with .NET Core (Linux, MacOS)
// process.env.EDGE_USE_CORECLR = 1;

var connect = edge.func({
    source: function() {/*
        using System.Threading.Tasks;
		using UnderAutomation.UniversalRobots;

        public class Startup
        {
            public async Task<object> Invoke(object ip)
            {
                UR ur = new UR();
				ur.Connect((string)ip);
				
				// Wait for data to be sent
				System.Threading.Thread.Sleep(400);
				
				return ur;
            }
        }
    */},
    references: [ '../../Libraries/net35/UnderAutomation.UniversalRobots.dll' ]
});

connect('192.168.0.56', function (error, result) {
    if (error) throw error;
	
	// Print robot streamed data as Json
    console.log(result);
	
	
});