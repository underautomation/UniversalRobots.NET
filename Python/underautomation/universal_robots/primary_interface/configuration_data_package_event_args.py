import typing
from underautomation.universal_robots.common.controller_box_types import ControllerBoxTypes
from underautomation.universal_robots.common.robot_models import RobotModels
from underautomation.universal_robots.common.robot_sub_types import RobotSubTypes
from underautomation.universal_robots.primary_interface.joint_configuration import JointConfiguration
from underautomation.universal_robots.common.package_event_args import PackageEventArgs
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.PrimaryInterface import ConfigurationDataPackageEventArgs as configuration_data_package_event_args

class ConfigurationDataPackageEventArgs(PackageEventArgs):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = configuration_data_package_event_args()
		else:
			self._instance = _internal
	@property
	def v_joint_default(self) -> float:
		return self._instance.VJointDefault
	@v_joint_default.setter
	def v_joint_default(self, value: float):
		self._instance.VJointDefault = value
	@property
	def a_joint_default(self) -> float:
		return self._instance.AJointDefault
	@a_joint_default.setter
	def a_joint_default(self, value: float):
		self._instance.AJointDefault = value
	@property
	def v_tool_default(self) -> float:
		return self._instance.VToolDefault
	@v_tool_default.setter
	def v_tool_default(self, value: float):
		self._instance.VToolDefault = value
	@property
	def a_tool_default(self) -> float:
		return self._instance.AToolDefault
	@a_tool_default.setter
	def a_tool_default(self, value: float):
		self._instance.AToolDefault = value
	@property
	def eq_radius(self) -> float:
		return self._instance.EqRadius
	@eq_radius.setter
	def eq_radius(self, value: float):
		self._instance.EqRadius = value
	@property
	def masterboard_version(self) -> int:
		return self._instance.MasterboardVersion
	@masterboard_version.setter
	def masterboard_version(self, value: int):
		self._instance.MasterboardVersion = value
	@property
	def controller_box_type(self) -> ControllerBoxTypes:
		return ControllerBoxTypes(self._instance.ControllerBoxType)
	@controller_box_type.setter
	def controller_box_type(self, value: ControllerBoxTypes):
		self._instance.ControllerBoxType = value
	@property
	def robot_type(self) -> RobotModels:
		return RobotModels(self._instance.RobotType)
	@robot_type.setter
	def robot_type(self, value: RobotModels):
		self._instance.RobotType = value
	@property
	def robot_sub_type(self) -> RobotSubTypes:
		return RobotSubTypes(self._instance.RobotSubType)
	@robot_sub_type.setter
	def robot_sub_type(self, value: RobotSubTypes):
		self._instance.RobotSubType = value
	@property
	def base(self) -> JointConfiguration:
		return JointConfiguration(self._instance.Base)
	@base.setter
	def base(self, value: JointConfiguration):
		self._instance.Base = value
	@property
	def shoulder(self) -> JointConfiguration:
		return JointConfiguration(self._instance.Shoulder)
	@shoulder.setter
	def shoulder(self, value: JointConfiguration):
		self._instance.Shoulder = value
	@property
	def elbow(self) -> JointConfiguration:
		return JointConfiguration(self._instance.Elbow)
	@elbow.setter
	def elbow(self, value: JointConfiguration):
		self._instance.Elbow = value
	@property
	def wrist1(self) -> JointConfiguration:
		return JointConfiguration(self._instance.Wrist1)
	@wrist1.setter
	def wrist1(self, value: JointConfiguration):
		self._instance.Wrist1 = value
	@property
	def wrist2(self) -> JointConfiguration:
		return JointConfiguration(self._instance.Wrist2)
	@wrist2.setter
	def wrist2(self, value: JointConfiguration):
		self._instance.Wrist2 = value
	@property
	def wrist3(self) -> JointConfiguration:
		return JointConfiguration(self._instance.Wrist3)
	@wrist3.setter
	def wrist3(self, value: JointConfiguration):
		self._instance.Wrist3 = value
