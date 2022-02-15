import typing
from underautomation.universal_robots.internal.primary_interface_client_internal import PrimaryInterfaceClientInternal
from underautomation.universal_robots.internal.xml_rpc_server_internal import XmlRpcServerInternal
from underautomation.universal_robots.internal.dashboard_client_internal import DashboardClientInternal
from underautomation.universal_robots.internal.socket_communication_server_internal import SocketCommunicationServerInternal
from underautomation.universal_robots.internal.rtde_client_internal import RtdeClientInternal
from underautomation.universal_robots.internal.ssh_client_internal import SshClientInternal
from underautomation.universal_robots.internal.sftp_client_internal import SftpClientInternal
from underautomation.universal_robots.connect_parameters import ConnectParameters
from underautomation.universal_robots.license.license_info import LicenseInfo
from underautomation.universal_robots.internal.ur_service_base import URServiceBase
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots import UR as ur

class UR(URServiceBase):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = ur()
		else:
			self._instance = _internal
	def connect(self, parameters: ConnectParameters) -> None:
		self._instance.Connect(parameters._instance)
	def disconnect(self) -> None:
		self._instance.Disconnect()
	@staticmethod
	def register_license(licensee: str, key: str) -> LicenseInfo:
		return ur.RegisterLicense(licensee, key)
	@property
	def primary_interface(self) -> PrimaryInterfaceClientInternal:
		return PrimaryInterfaceClientInternal(self._instance.PrimaryInterface)
	@property
	def xml_rpc(self) -> XmlRpcServerInternal:
		return XmlRpcServerInternal(self._instance.XmlRpc)
	@property
	def dashboard(self) -> DashboardClientInternal:
		return DashboardClientInternal(self._instance.Dashboard)
	@property
	def socket_communication(self) -> SocketCommunicationServerInternal:
		return SocketCommunicationServerInternal(self._instance.SocketCommunication)
	@property
	def rtde(self) -> RtdeClientInternal:
		return RtdeClientInternal(self._instance.Rtde)
	@property
	def ssh(self) -> SshClientInternal:
		return SshClientInternal(self._instance.Ssh)
	@property
	def sftp(self) -> SftpClientInternal:
		return SftpClientInternal(self._instance.Sftp)
	@property
	def ip(self) -> str:
		return self._instance.IP
	@property
	def enabled(self) -> bool:
		return self._instance.Enabled
	@property
	def license_info(self) -> LicenseInfo:
		return LicenseInfo(None, None, self._instance.LicenseInfo)
