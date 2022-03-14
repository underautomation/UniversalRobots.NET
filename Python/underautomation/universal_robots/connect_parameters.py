import typing
from underautomation.universal_robots.common.primary_interface_connect_parameters import PrimaryInterfaceConnectParameters
from underautomation.universal_robots.common.dashboard_connect_parameters import DashboardConnectParameters
from underautomation.universal_robots.common.socket_communication_connect_parameters import SocketCommunicationConnectParameters
from underautomation.universal_robots.common.ssh_connect_parameters import SshConnectParameters
from underautomation.universal_robots.common.rtde_connect_parameters import RtdeConnectParameters
from underautomation.universal_robots.common.xml_rpc_connect_parameters import XmlRpcConnectParameters
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__),  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots import ConnectParameters as connect_parameters

class ConnectParameters:
	def __init__(self, ip: str, _internal = 0):
		if(_internal == 0):
			self._instance = connect_parameters(ip)
		else:
			self._instance = _internal
	@property
	def ip(self) -> str:
		return self._instance.IP
	@ip.setter
	def ip(self, value: str):
		self._instance.IP = value
	@property
	def ping_before_connecting(self) -> bool:
		return self._instance.PingBeforeConnecting
	@ping_before_connecting.setter
	def ping_before_connecting(self, value: bool):
		self._instance.PingBeforeConnecting = value
	@property
	def primary_interface(self) -> PrimaryInterfaceConnectParameters:
		return PrimaryInterfaceConnectParameters(self._instance.PrimaryInterface)
	@primary_interface.setter
	def primary_interface(self, value: PrimaryInterfaceConnectParameters):
		self._instance.PrimaryInterface = value
	@property
	def dashboard(self) -> DashboardConnectParameters:
		return DashboardConnectParameters(self._instance.Dashboard)
	@dashboard.setter
	def dashboard(self, value: DashboardConnectParameters):
		self._instance.Dashboard = value
	@property
	def socket_communication(self) -> SocketCommunicationConnectParameters:
		return SocketCommunicationConnectParameters(self._instance.SocketCommunication)
	@socket_communication.setter
	def socket_communication(self, value: SocketCommunicationConnectParameters):
		self._instance.SocketCommunication = value
	@property
	def ssh(self) -> SshConnectParameters:
		return SshConnectParameters(self._instance.Ssh)
	@ssh.setter
	def ssh(self, value: SshConnectParameters):
		self._instance.Ssh = value
	@property
	def rtde(self) -> RtdeConnectParameters:
		return RtdeConnectParameters(self._instance.Rtde)
	@rtde.setter
	def rtde(self, value: RtdeConnectParameters):
		self._instance.Rtde = value
	@property
	def xml_rpc(self) -> XmlRpcConnectParameters:
		return XmlRpcConnectParameters(self._instance.XmlRpc)
	@xml_rpc.setter
	def xml_rpc(self, value: XmlRpcConnectParameters):
		self._instance.XmlRpc = value
