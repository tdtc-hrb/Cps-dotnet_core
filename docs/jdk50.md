old communication server
====

## JAVA
use 32-bit JAVA Env

### [eclipse](https://www.eclipse.org/downloads/download.php?file=/technology/epp/downloads/release/indigo/SR2/eclipse-java-indigo-SR2-win32.zip)
The original test environment was [JDK5](https://download.oracle.com/otn/java/jdk/1.5.0_22/jdk-1_5_0_22-windows-i586-p.exe) and used TLSv1.0.

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

### [See Protocol](https://support.azul.com/hc/en-us/articles/360061894852-Which-security-protocols-and-cipher-suites-are-enabled-in-a-specific-Java-Release-)
java 1.5:
```java
package prjSSL;

import javax.net.ssl.SSLSocket;
import javax.net.ssl.SSLContext;
import javax.net.ssl.SSLSocketFactory;

import java.io.IOException;
import java.security.KeyManagementException;
import java.security.NoSuchAlgorithmException;

public class ProtocolTest {
    /**
     * @param args
     * @throws NoSuchAlgorithmException 
     * @throws KeyManagementException 
     * @throws IOException 
     */
    public static void main(String[] args) 
            throws NoSuchAlgorithmException, KeyManagementException, IOException {
        SSLContext context = SSLContext.getInstance("SSL");
        context.init(null,null,null);
        SSLSocketFactory factory = (SSLSocketFactory)context.getSocketFactory();
        SSLSocket socket = (SSLSocket)factory.createSocket();
        String[] protocols = socket.getSupportedProtocols();
        System.out.println("Supported Protocols: " + protocols.length);
        
        for(int i = 0; i < protocols.length; i++) {
          System.out.println(" " + protocols[i]);
        }
        protocols = socket.getEnabledProtocols(); 
        System.out.println("\nEnabled Protocols: " + protocols.length);
        
        for(int i = 0; i < protocols.length; i++) { 
          System.out.println(" " + protocols[i]); 
        }
        System.out.println("\nSupported Cipher Suites: ");
        
        try {
          String[] ciphers = factory.getSupportedCipherSuites();
          for (int i = 1; i < ciphers.length; i++) {
            System.out.println(" " + i + ". " + ciphers[i]);
          }
        } catch (Exception e) {
          System.out.println("Failed to get default SSL context.");
        }
    }
}
```

### run
- Server
```cmd
java -Dfile.encoding=UTF8 -classpath "C:/commsrv2;C:/commsrv2/lib/log4j-1.2.17.jar;C:/commsrv2/lib/xom-1.1.jar" Server C:/receive/configQ.xml
```

- Client
```cmd
java -Dfile.encoding=UTF8 -classpath "C:/commclient2;C:/commclient2/lib/log4j-1.2.17.jar;C:/commclient2/lib/xom-1.1.jar" Client C:/send/configQ.xml 3
```

#### ecoding
[Basic Encoding Set](https://docs.oracle.com/javase/8/docs/technotes/guides/intl/encoding.doc.html)
