import typing
from underautomation.universal_robots.ssh.tools.expect_action import ExpectAction
from underautomation.universal_robots.ssh.tools.common.shell_data_event_args import ShellDataEventArgs
from underautomation.universal_robots.ssh.tools.common.exception_event_args import ExceptionEventArgs
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools import ShellStream as shell_stream

class ShellStream:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = shell_stream()
		else:
			self._instance = _internal
	def data_received(self, handler):
		class Wrapper :
			def __init__(self, _internal):
				self._instance = _internal
		self._instance.DataReceived+= lambda sender, e : handler(Wrapper(sender), Wrapper(e))
	def error_occurred(self, handler):
		class Wrapper :
			def __init__(self, _internal):
				self._instance = _internal
		self._instance.ErrorOccurred+= lambda sender, e : handler(Wrapper(sender), Wrapper(e))
	def flush(self) -> None:
		self._instance.Flush()
	def read(self, buffer: typing.List[int], offset: int, count: int) -> int:
		return self._instance.Read(buffer, offset, count)
	def seek(self, offset: int, origin: typing.Any) -> int:
		return self._instance.Seek(offset, origin)
	def set_length(self, value: int) -> None:
		self._instance.SetLength(value)
	def write(self, buffer: typing.List[int], offset: int, count: int) -> None:
		self._instance.Write(buffer, offset, count)
	def expect(self, regex: typing.Any, timeout: typing.Any) -> str:
		return self._instance.Expect(regex, timeout)
	def begin_expect(self, timeout: typing.Any, callback: typing.Any, state: typing.Any, expectActions: typing.List[ExpectAction]) -> typing.Any:
		return self._instance.BeginExpect(timeout, callback, state, expectActions._instance)
	def end_expect(self, asyncResult: typing.Any) -> str:
		return self._instance.EndExpect(asyncResult)
	def read_line(self, timeout: typing.Any) -> str:
		return self._instance.ReadLine(timeout)
	def write_line(self, line: str) -> None:
		self._instance.WriteLine(line)
	@property
	def data_available(self) -> bool:
		return self._instance.DataAvailable
	@property
	def can_read(self) -> bool:
		return self._instance.CanRead
	@property
	def can_seek(self) -> bool:
		return self._instance.CanSeek
	@property
	def can_write(self) -> bool:
		return self._instance.CanWrite
	@property
	def length(self) -> int:
		return self._instance.Length
	@property
	def position(self) -> int:
		return self._instance.Position
	@position.setter
	def position(self, value: int):
		self._instance.Position = value
