import typing
from underautomation.universal_robots.internal_error_event_args import InternalErrorEventArgs
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Internal import URServiceBase as urservice_base

class URServiceBase:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = urservice_base()
		else:
			self._instance = _internal
	def internal_error_occured(self, handler):
		class Wrapper :
			def __init__(self, _internal):
				self._instance = _internal
		self._instance.InternalErrorOccured+= lambda sender, e : handler(Wrapper(sender), Wrapper(e))
