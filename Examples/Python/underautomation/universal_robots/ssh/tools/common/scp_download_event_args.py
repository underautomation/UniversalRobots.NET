import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Common import ScpDownloadEventArgs as scp_download_event_args

class ScpDownloadEventArgs:
	def __init__(self, filename: str, size: int, downloaded: int, _internal = 0):
		if(_internal == 0):
			self._instance = scp_download_event_args(filename, size, downloaded)
		else:
			self._instance = _internal
	@property
	def filename(self) -> str:
		return self._instance.Filename
	@property
	def size(self) -> int:
		return self._instance.Size
	@property
	def downloaded(self) -> int:
		return self._instance.Downloaded
