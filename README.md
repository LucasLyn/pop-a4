# PoP - Assignment 4
PoP - 4i

This assignment is about tracing and testing. In this case, a vector library was given, which should be traced and tested.


# PoP - 4i


## Kode

The library is compiled with fsharpc;

	$ fsharpc -a vec2dsmall.fsi vec2dsmall.fs


The code is compiled with the library with fsharpc and run with mono;

	$ fsharpc -r vec2dsmall.dll 4i1.fsx
	$ fsharpc -r vec2dsmall.dll 4i2.fsx
	$ mono 4i1.exe
	$ mono 4i2.exe


The library is compiled to XML with fsharpc;

	$ fsharpc --doc:vec2dsmall.xml -a vec2dsmall.fsi vec2dsmall.fs
 
