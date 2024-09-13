# CPS dotnet core
The current version of the communication software does not support non-ASCII encoded file transfer.

## JAVA
use 32-bit JAVA Env

### property
> port.properties
The root directory of the current executable.

- Windows CMD
```cmd
C:\Users\xiaobin\
```

- Application
Cps_x35.exe directory.


### JKS
- [cmd](https://docs.oracle.com/en/java/javase/18/docs/specs/man/keytool.html)
- [gui](https://keystore-explorer.org/downloads.html)

keystore 文件变更:
- 文件 size
```
1024
```
变更为:
```
2048
```
- 密码套件
```
SHA1 with DSA
```
变更为:
```
SHA256 with RSA
```

### run
- Server
```cmd
java -Dfile.encoding=UTF8 -classpath "C:/commsrv2;C:/commsrv2/lib/log4j-1.2.17.jar;C:/commsrv2/lib/xom-1.1.jar;C:/commsrv2/lib/bctls-fips-1.0.19.jar;C:/commsrv2/lib/bc-fips-1.0.2.4.jar" Server C:/receive/configQ.xml
```

- Client
```cmd
java -Dfile.encoding=UTF8 -classpath "C:/commclient2;C:/commclient2/lib/log4j-1.2.17.jar;C:/commclient2/lib/xom-1.1.jar;C:/commclient2/lib/bctls-fips-1.0.19.jar;C:/commclient2/lib/bc-fips-1.0.2.4.jar" Client C:/send/configQ.xml 3
```
