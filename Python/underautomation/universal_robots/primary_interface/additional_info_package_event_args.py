import typing
from underautomation.universal_robots.common.package_event_args import PackageEventArgs
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.PrimaryInterface import AdditionalInfoPackageEventArgs as additional_info_package_event_args

class AdditionalInfoPackageEventArgs(PackageEventArgs):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = additional_info_package_event_args()
		else:
			self._instance = _internal
	@property
	def freedrive_button_pressed(self) -> bool:
		return self._instance.FreedriveButtonPressed
	@freedrive_button_pressed.setter
	def freedrive_button_pressed(self, value: bool):
		self._instance.FreedriveButtonPressed = value
	@property
	def freedrive_button_enabled(self) -> bool:
		return self._instance.FreedriveButtonEnabled
	@freedrive_button_enabled.setter
	def freedrive_button_enabled(self, value: bool):
		self._instance.FreedriveButtonEnabled = value
	@property
	def io_enabled_freedrive(self) -> bool:
		return self._instance.IOEnabledFreedrive
	@io_enabled_freedrive.setter
	def io_enabled_freedrive(self, value: bool):
		self._instance.IOEnabledFreedrive = value
