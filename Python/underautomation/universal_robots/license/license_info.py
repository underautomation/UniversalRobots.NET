import typing
from underautomation.universal_robots.license.license_state import LicenseState
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.License import LicenseInfo as license_info

class LicenseInfo:
	def __init__(self, licenseIdentifier: str, licenseKey: str, _internal = 0):
		if(_internal == 0):
			self._instance = license_info(licenseIdentifier, licenseKey)
		else:
			self._instance = _internal
	def __repr__(self):
		return self._instance.ToString()
	@property
	def license_key(self) -> str:
		return self._instance.LicenseKey
	@property
	def product(self) -> str:
		return self._instance.Product
	@property
	def evaluation_days_left(self) -> typing.Any:
		return self._instance.EvaluationDaysLeft
	@property
	def evaluation_start_date(self) -> typing.Any:
		return self._instance.EvaluationStartDate
	@property
	def licensee(self) -> str:
		return self._instance.Licensee
	@property
	def trial_period_expiration_date(self) -> typing.Any:
		return self._instance.TrialPeriodExpirationDate
	@property
	def state(self) -> LicenseState:
		return LicenseState(self._instance.State)
	@property
	def product_release_date(self) -> typing.Any:
		return self._instance.ProductReleaseDate
	@property
	def maintenance_years(self) -> int:
		return self._instance.MaintenanceYears
	@property
	def license_issued_date(self) -> typing.Any:
		return self._instance.LicenseIssuedDate
	@property
	def maintenance_expiration_date(self) -> typing.Any:
		return self._instance.MaintenanceExpirationDate
