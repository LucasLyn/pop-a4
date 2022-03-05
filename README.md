# PoP - Assignment 4
PoP - 4i

Don't be stupid...


# PoP - 4i


## Kode

Først compiles module filerne til en .dll fil med fsharpc;

	$ fsharpc -a vec2dsmall.fsi vec2dsmall.fs


Derefter compiles 4i1 med fsharpc, og køres derefter med mono;

	$ fsharpc -r vec2dsmall.dll 4i1.fsx
	$ mono 4i1.exe


Til sidst compiles og køres 4i2 med fsharpc og mono;

	$ fsharpc -r vec2dsmall.dll 4i2.fsx
	$ mono 4i2.exe


vec2dsmall.fsi compiles til XML med fsharpc;

	$ fsharpc --doc:vec2dsmall.xml -a vec2dsmall.fsi vec2dsmall.fs
 
