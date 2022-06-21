from underautomation.universal_robots.files.ur_program import URProgram

import clr

clr.AddReference("System.Xml.Linq")

from System.Xml.Linq import XElement

prg = URProgram.load("D:\\System\\UA\\UniversalRobots\\Submodules\\Samples\\.NET\\Examples\\WindowsDesktop\\Samples\\xml_rpc_sample.urp")

xmlString = prg.xml.ToString()

## Edit xmlString

modifiedPrg = URProgram(XElement.Parse(xmlString))

modifiedPrg.save("path\\to\\program.urp")