import typing
from underautomation.universal_robots.dashboard.internal.dashboard_client_base import DashboardClientBase
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Dashboard import DashboardClient as dashboard_client

class DashboardClient(DashboardClientBase):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = dashboard_client()
		else:
			self._instance = _internal
	def enable(self, ip: str) -> None:
		self._instance.Enable(ip)
