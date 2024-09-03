//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Internal;
using InterpreterMode;

namespace InterpreterMode.Internal {

	public abstract class InterpreterModeClientBase : URServiceBase {

		/// <summary>
		/// IP of the robot to connect to for sending commands
		/// </summary>
		public string IP { get; }

		/// <summary>
		/// Interpreter mode server port
		/// </summary>
		public int Port { get; set; }


		protected void ConnectInternal(string ip, int port)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Executes a command on the Interpreter Mode
		/// </summary>
		/// <param name="command">URScript statement to execute</param>
		public CommandResponse ExecuteCommand(string command)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Ends the interpreter mode, and causes the interpreter_mode() function to return. This
		/// function can be compiled into the program by sending it to the interpreter socket(30020) as any
		/// other statement, or can be called from anywhere else in the program.
		/// By default everything interpreted will be cleared when ending, though the state of the robot, the
		/// modifications to local variables from the enclosing scope, and the global variables will remain
		/// affected by any changes made.The interpreter thread will be idle after this call.
		/// </summary>
		public CommandResponse EndInterpreter()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Clears all interpreted statements, objects, functions, threads, etc. generated in the current
		/// interpreter mode.Threads started in current interpreter session will be stopped, and deleted.
		/// Variables defined outside of the current interpreter mode will not be affected by a call to thisfunction.
		/// Only statements interpreted before the clear_interpreter() function will be cleared.
		/// Statements sent after clear_interpreter() will be queued. When cleaning is done, any
		/// statements queued are interpreted and responded to. Note that commands such as abort,
		/// skipbuffer and state commands are executed as soon as they are received.
		/// </summary>
		public CommandResponse ClearInterpreter()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// The interpreter mode offers a mechanism to abort limited number of script functions, even if they are
		/// called from the main program. Currently only movej and movel can be aborted.
		/// Aborting a movement will result in a controlled stop if no blend radius is defined.
		/// If a blend radius is defined then a blend with the next movement will be initiated right away if not
		/// already in an initial blend, otherwise the command is ignored.
		/// Return value should be ignored
		/// </summary>
		public CommandResponse Abort()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// The interpreter mode furthermore supports the opportunity to skip already sent but not executed
		/// statements.The interpreter thread will then(after finishing the currently executing statement) skip
		/// all received but not executed statements.
		/// After the skip, the interpreter thread will idle until new statements are received.skipbuffer will
		/// only skip already received statements, new statements can therefore be send right away.
		/// Return value should be ignored
		/// </summary>
		public CommandResponse SkipBuffer()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Replies with the largest id of a statement that has started being executed.
		/// </summary>
		public CommandResponse StateLastExecuted()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Replies with the latest interpreted id, i.e. the highest number of interpreted statement so far.
		/// </summary>
		public CommandResponse StateLastInterpreted()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Replies with the id for the latest statement to be cleared from the interpreter mode. This clear can happen when ending interpreter mode, or by calls to clear_interpreter()
		/// </summary>
		public CommandResponse StateLastCleared()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Replies with the number of non executed statements, i.e. the number of statements that would have be skipped if skipbuffer was called instead.
		/// </summary>
		public CommandResponse StateLastUnexecuted()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Disconnect interpreter mode socket connection
		/// </summary>
		public void Disconnect()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Indicates that the interpreter mode client is connected and ready to send commands
		/// </summary>
		public bool Connected { get; }
	}
}
