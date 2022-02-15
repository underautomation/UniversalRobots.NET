import typing
from underautomation.universal_robots.ssh.tools.sftp.sftp_file import SftpFile
from underautomation.universal_robots.ssh.tools.sftp.sftp_file_sytem_information import SftpFileSytemInformation
from underautomation.universal_robots.ssh.tools.sftp.sftp_file_stream import SftpFileStream
from underautomation.universal_robots.ssh.tools.sftp.sftp_file_attributes import SftpFileAttributes
from underautomation.universal_robots.internal.ur_service_base import URServiceBase
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Internal import SftpClientBase as sftp_client_base

class SftpClientBase(URServiceBase):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = sftp_client_base()
		else:
			self._instance = _internal
	def disconnect(self) -> None:
		self._instance.Disconnect()
	def change_directory(self, path: str) -> None:
		self._instance.ChangeDirectory(path)
	def change_permissions(self, path: str, mode: int) -> None:
		self._instance.ChangePermissions(path, mode)
	def create_directory(self, path: str) -> None:
		self._instance.CreateDirectory(path)
	def delete_directory(self, path: str) -> None:
		self._instance.DeleteDirectory(path)
	def delete_file(self, path: str) -> None:
		self._instance.DeleteFile(path)
	def rename_file(self, oldPath: str, newPath: str, isPosix: bool) -> None:
		self._instance.RenameFile(oldPath, newPath, isPosix)
	def symbolic_link(self, path: str, linkPath: str) -> None:
		self._instance.SymbolicLink(path, linkPath)
	def list_directory(self, path: str, listCallback: typing.Any=None) -> typing.List[SftpFile]:
		return [SftpFile(x) for x in self._instance.ListDirectory(path, listCallback)]
	def begin_list_directory(self, path: str, asyncCallback: typing.Any, state: typing.Any, listCallback: typing.Any=None) -> typing.Any:
		return self._instance.BeginListDirectory(path, asyncCallback, state, listCallback)
	def end_list_directory(self, asyncResult: typing.Any) -> typing.List[SftpFile]:
		return [SftpFile(x) for x in self._instance.EndListDirectory(asyncResult)]
	def get(self, path: str) -> SftpFile:
		return SftpFile(self._instance.Get(path))
	def exists(self, path: str) -> bool:
		return self._instance.Exists(path)
	def download_file(self, path: str, output: typing.Any, downloadCallback: typing.Any=None) -> None:
		self._instance.DownloadFile(path, output, downloadCallback)
	def begin_download_file(self, path: str, output: typing.Any, asyncCallback: typing.Any, state: typing.Any, downloadCallback: typing.Any=None) -> typing.Any:
		return self._instance.BeginDownloadFile(path, output, asyncCallback, state, downloadCallback)
	def end_download_file(self, asyncResult: typing.Any) -> None:
		self._instance.EndDownloadFile(asyncResult)
	def upload_file(self, input: typing.Any, path: str, canOverride: bool, uploadCallback: typing.Any=None) -> None:
		self._instance.UploadFile(input, path, canOverride, uploadCallback)
	def begin_upload_file(self, input: typing.Any, path: str, canOverride: bool, asyncCallback: typing.Any, state: typing.Any, uploadCallback: typing.Any=None) -> typing.Any:
		return self._instance.BeginUploadFile(input, path, canOverride, asyncCallback, state, uploadCallback)
	def end_upload_file(self, asyncResult: typing.Any) -> None:
		self._instance.EndUploadFile(asyncResult)
	def get_status(self, path: str) -> SftpFileSytemInformation:
		return SftpFileSytemInformation(self._instance.GetStatus(path))
	def append_all_lines(self, path: str, contents: typing.List[str], encoding: typing.Any) -> None:
		self._instance.AppendAllLines(path, contents, encoding)
	def append_all_text(self, path: str, contents: str, encoding: typing.Any) -> None:
		self._instance.AppendAllText(path, contents, encoding)
	def append_text(self, path: str, encoding: typing.Any) -> typing.Any:
		return self._instance.AppendText(path, encoding)
	def create(self, path: str, bufferSize: int) -> SftpFileStream:
		return SftpFileStream(self._instance.Create(path, bufferSize))
	def create_text(self, path: str, encoding: typing.Any) -> typing.Any:
		return self._instance.CreateText(path, encoding)
	def delete(self, path: str) -> None:
		self._instance.Delete(path)
	def get_last_access_time(self, path: str) -> typing.Any:
		return self._instance.GetLastAccessTime(path)
	def get_last_access_time_utc(self, path: str) -> typing.Any:
		return self._instance.GetLastAccessTimeUtc(path)
	def get_last_write_time(self, path: str) -> typing.Any:
		return self._instance.GetLastWriteTime(path)
	def get_last_write_time_utc(self, path: str) -> typing.Any:
		return self._instance.GetLastWriteTimeUtc(path)
	def open(self, path: str, mode: typing.Any, access: typing.Any) -> SftpFileStream:
		return SftpFileStream(self._instance.Open(path, mode, access))
	def open_read(self, path: str) -> SftpFileStream:
		return SftpFileStream(self._instance.OpenRead(path))
	def open_text(self, path: str) -> typing.Any:
		return self._instance.OpenText(path)
	def open_write(self, path: str) -> SftpFileStream:
		return SftpFileStream(self._instance.OpenWrite(path))
	def read_all_bytes(self, path: str) -> typing.List[int]:
		return self._instance.ReadAllBytes(path)
	def read_all_lines(self, path: str, encoding: typing.Any) -> typing.List[str]:
		return self._instance.ReadAllLines(path, encoding)
	def read_all_text(self, path: str, encoding: typing.Any) -> str:
		return self._instance.ReadAllText(path, encoding)
	def read_lines(self, path: str, encoding: typing.Any) -> typing.List[str]:
		return self._instance.ReadLines(path, encoding)
	def write_all_bytes(self, path: str, bytes: typing.List[int]) -> None:
		self._instance.WriteAllBytes(path, bytes)
	def write_all_lines(self, path: str, contents: typing.List[str]) -> None:
		self._instance.WriteAllLines(path, contents)
	def write_all_text(self, path: str, contents: str, encoding: typing.Any) -> None:
		self._instance.WriteAllText(path, contents, encoding)
	def get_attributes(self, path: str) -> SftpFileAttributes:
		return SftpFileAttributes(self._instance.GetAttributes(path))
	def set_attributes(self, path: str, fileAttributes: SftpFileAttributes) -> None:
		self._instance.SetAttributes(path, fileAttributes._instance)
	def synchronize_directories(self, sourcePath: str, destinationPath: str, searchPattern: str) -> typing.List[typing.Any]:
		return self._instance.SynchronizeDirectories(sourcePath, destinationPath, searchPattern)
	def begin_synchronize_directories(self, sourcePath: str, destinationPath: str, searchPattern: str, asyncCallback: typing.Any, state: typing.Any) -> typing.Any:
		return self._instance.BeginSynchronizeDirectories(sourcePath, destinationPath, searchPattern, asyncCallback, state)
	def end_synchronize_directories(self, asyncResult: typing.Any) -> typing.List[typing.Any]:
		return self._instance.EndSynchronizeDirectories(asyncResult)
	@property
	def connected(self) -> bool:
		return self._instance.Connected
	@property
	def operation_timeout(self) -> typing.Any:
		return self._instance.OperationTimeout
	@operation_timeout.setter
	def operation_timeout(self, value: typing.Any):
		self._instance.OperationTimeout = value
	@property
	def buffer_size(self) -> int:
		return self._instance.BufferSize
	@buffer_size.setter
	def buffer_size(self, value: int):
		self._instance.BufferSize = value
	@property
	def working_directory(self) -> str:
		return self._instance.WorkingDirectory
	@property
	def protocol_version(self) -> int:
		return self._instance.ProtocolVersion
