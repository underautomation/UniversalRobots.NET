import typing
from underautomation.universal_robots.dashboard.command_response import CommandResponse
from underautomation.universal_robots.dashboard.command_response_1 import CommandResponse1
from underautomation.universal_robots.dashboard.user_roles import UserRoles
from underautomation.universal_robots.dashboard.operational_modes import OperationalModes
from underautomation.universal_robots.internal.ur_service_base import URServiceBase
from underautomation.universal_robots.common.global_variable import GlobalVariable
from underautomation.universal_robots.common.robot_modes import RobotModes
from underautomation.universal_robots.dashboard.program_save_state import ProgramSaveState
from underautomation.universal_robots.dashboard.program_state import ProgramState
from underautomation.universal_robots.dashboard.polyscope_version import PolyscopeVersion
from underautomation.universal_robots.common.safety_status import SafetyStatus
from underautomation.universal_robots.common.robot_models import RobotModels
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Dashboard.Internal import DashboardClientBase as dashboard_client_base

class DashboardClientBase(URServiceBase):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = dashboard_client_base()
		else:
			self._instance = _internal
	def disable(self) -> None:
		self._instance.Disable()
	def load_program(self, programName: str) -> CommandResponse:
		return CommandResponse(self._instance.LoadProgram(programName))
	def play(self) -> CommandResponse:
		return CommandResponse(self._instance.Play())
	def stop(self) -> CommandResponse:
		return CommandResponse(self._instance.Stop())
	def pause(self) -> CommandResponse:
		return CommandResponse(self._instance.Pause())
	def send_custom_dashboard_command(self, command: str) -> CommandResponse:
		return CommandResponse(self._instance.SendCustomDashboardCommand(command))
	def get_variable(self, name: str) -> CommandResponse1[GlobalVariable]:
		return CommandResponse1[GlobalVariable](None, self._instance.GetVariable(name))
	def shutdown(self) -> CommandResponse:
		return CommandResponse(self._instance.Shutdown())
	def is_program_running(self) -> CommandResponse1[bool]:
		return CommandResponse1[bool](None, self._instance.IsProgramRunning())
	def get_robot_mode(self) -> CommandResponse1[RobotModes]:
		return CommandResponse1[RobotModes](None, self._instance.GetRobotMode())
	def get_loaded_program(self) -> CommandResponse1[str]:
		return CommandResponse1[str](None, self._instance.GetLoadedProgram())
	def show_popup(self, message: str) -> CommandResponse:
		return CommandResponse(self._instance.ShowPopup(message))
	def close_popup(self) -> CommandResponse:
		return CommandResponse(self._instance.ClosePopup())
	def add_to_log(self, message: str) -> CommandResponse:
		return CommandResponse(self._instance.AddToLog(message))
	def is_program_saved(self) -> CommandResponse1[ProgramSaveState]:
		return CommandResponse1[ProgramSaveState](None, self._instance.IsProgramSaved())
	def get_program_state(self) -> CommandResponse1[ProgramState]:
		return CommandResponse1[ProgramState](None, self._instance.GetProgramState())
	def get_polyscope_version(self) -> CommandResponse1[PolyscopeVersion]:
		return CommandResponse1[PolyscopeVersion](None, self._instance.GetPolyscopeVersion())
	def set_user_role(self, role: UserRoles) -> CommandResponse:
		return CommandResponse(self._instance.SetUserRole(role._instance))
	def set_operational_mode(self, mode: OperationalModes) -> CommandResponse:
		return CommandResponse(self._instance.SetOperationalMode(mode._instance))
	def clear_operational_mode(self) -> CommandResponse:
		return CommandResponse(self._instance.ClearOperationalMode())
	def get_operational_mode(self) -> CommandResponse1[OperationalModes]:
		return CommandResponse1[OperationalModes](None, self._instance.GetOperationalMode())
	def is_in_remote_control(self) -> CommandResponse1[bool]:
		return CommandResponse1[bool](None, self._instance.IsInRemoteControl())
	def power_on(self) -> CommandResponse:
		return CommandResponse(self._instance.PowerOn())
	def power_off(self) -> CommandResponse:
		return CommandResponse(self._instance.PowerOff())
	def release_brake(self) -> CommandResponse:
		return CommandResponse(self._instance.ReleaseBrake())
	def unlock_protective_stop(self) -> CommandResponse:
		return CommandResponse(self._instance.UnlockProtectiveStop())
	def close_safety_popup(self) -> CommandResponse:
		return CommandResponse(self._instance.CloseSafetyPopup())
	def load_installation(self, installation: str) -> CommandResponse:
		return CommandResponse(self._instance.LoadInstallation(installation))
	def restart_safety(self) -> CommandResponse:
		return CommandResponse(self._instance.RestartSafety())
	def get_safety_status(self) -> CommandResponse1[SafetyStatus]:
		return CommandResponse1[SafetyStatus](None, self._instance.GetSafetyStatus())
	def get_serial_number(self) -> CommandResponse:
		return CommandResponse(self._instance.GetSerialNumber())
	def get_robot_model(self) -> CommandResponse1[RobotModels]:
		return CommandResponse1[RobotModels](None, self._instance.GetRobotModel())
	@property
	def ip(self) -> str:
		return self._instance.IP
	@property
	def initialized(self) -> bool:
		return self._instance.Initialized
	@property
	def before_shutdown(self) -> typing.Any:
		return self._instance.BeforeShutdown
	@before_shutdown.setter
	def before_shutdown(self, value: typing.Any):
		self._instance.BeforeShutdown = value
