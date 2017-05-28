S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 13844
Date: 2017-05-09 02:25:04+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x75c

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x00000000, esi = 0x00000750
ebp = 0xbfe75b94, esp = 0xbfe75ad8
eax = 0xb2ca46a1, ebx = 0xb76ff000
ecx = 0x00000036, edx = 0xb2ca44d0
eip = 0xb76e499e

Memory Information
MemTotal:      123 KB
MemFree:        27 KB
Buffers:         5 KB
Cached:     170356 KB
VmPeak:      91140 KB
VmSize:      91140 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16592 KB
VmRSS:       16592 KB
VmData:      28352 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       33328 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 13844 TID = 13844
13844 13846 13975 13976 

Maps Information
b2c25000 b2c2f000 r-xp /usr/lib/libfeedback.so.0.1.4
b2c35000 b2c41000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2c42000 b2c63000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2c68000 b2c69000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2c6a000 b2c6f000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2c70000 b2c71000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2c72000 b2c74000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2c75000 b2c77000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2c78000 b2c84000 r-xp /usr/lib/libdrm.so.2.4.0
b2c85000 b2c88000 r-xp /usr/lib/libdri2.so.0.0.0
b2c89000 b2c93000 r-xp /usr/lib/libtbm.so.1.0.0
b2c94000 b2c95000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b2c9c000 b2c9d000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b2c9e000 b2c9f000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b2ca0000 b2ca3000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b2ca4000 b2ca7000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b2ca8000 b2cbd000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2cbe000 b2cd0000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b35d9000 b35df000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b35e0000 b3724000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3734000 b373d000 r-xp /usr/lib/libefl-extension.so.0.1.0
b373e000 b3744000 r-xp /opt/usr/apps/org.example.example/bin/example
b3746000 b377f000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4182000 b418d000 r-xp /lib/libnss_files-2.20-2014.11.so
b418f000 b419a000 r-xp /lib/libnss_nis-2.20-2014.11.so
b419c000 b41b3000 r-xp /lib/libnsl-2.20-2014.11.so
b41b7000 b41bf000 r-xp /lib/libnss_compat-2.20-2014.11.so
b41c1000 b41e5000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b41e6000 b41e7000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b41e8000 b41eb000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b41ec000 b41f3000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b41f4000 b41fe000 r-xp /usr/lib/libsensord-share.so
b41ff000 b421b000 r-xp /usr/lib/libsensor.so.1.2.0
b421d000 b4226000 r-xp /usr/lib/libappcore-common.so.1.1
b4229000 b422b000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4240000 b4242000 r-xp /usr/lib/libXau.so.6.0.0
b4243000 b4265000 r-xp /usr/lib/libxcb.so.1.1.0
b4267000 b4270000 r-xp /lib/libcrypt-2.20-2014.11.so
b4299000 b429b000 r-xp /usr/lib/libiri.so
b429c000 b42c2000 r-xp /lib/libexpat.so.1.5.2
b42c4000 b432f000 r-xp /usr/lib/libssl.so.1.0.0
b4335000 b4341000 r-xp /usr/lib/libethumb.so.1.13.0
b4342000 b4346000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4347000 b4598000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b13000 b5b23000 r-xp /usr/lib/libXi.so.6.1.0
b5b24000 b5b26000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b27000 b5b2d000 r-xp /usr/lib/libXtst.so.6.1.0
b5b2e000 b5b38000 r-xp /usr/lib/libXrender.so.1.3.0
b5b39000 b5b42000 r-xp /usr/lib/libXrandr.so.2.2.0
b5b44000 b5b46000 r-xp /usr/lib/libXinerama.so.1.0.0
b5b47000 b5b4c000 r-xp /usr/lib/libXfixes.so.3.1.0
b5b4d000 b5b5f000 r-xp /usr/lib/libXext.so.6.4.0
b5b60000 b5b62000 r-xp /usr/lib/libXdamage.so.1.1.0
b5b63000 b5b65000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5b67000 b5ca9000 r-xp /usr/lib/libX11.so.6.3.0
b5cad000 b5cb7000 r-xp /usr/lib/libXcursor.so.1.0.2
b5cb8000 b5cce000 r-xp /usr/lib/libudev.so.1.6.0
b5cd1000 b5cd5000 r-xp /lib/libattr.so.1.1.0
b5cd6000 b5d05000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d07000 b5d0d000 r-xp /usr/lib/libffi.so.6.0.2
b5d0e000 b5d31000 r-xp /lib/libz.so.1.2.8
b5d32000 b5d35000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d36000 b5e92000 r-xp /usr/lib/libxml2.so.2.9.2
b5e98000 b5f7f000 r-xp /usr/lib/libstdc++.so.6.0.20
b5f8c000 b5f8f000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5f90000 b5fb2000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5fb3000 b5fc7000 r-xp /lib/libresolv-2.20-2014.11.so
b5fcb000 b5fef000 r-xp /usr/lib/liblzma.so.5.0.3
b5ff0000 b5ff2000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5ff4000 b5ffe000 r-xp /usr/lib/libembryo.so.1.13.0
b5fff000 b6028000 r-xp /usr/lib/libpng12.so.0.50.0
b6029000 b6072000 r-xp /usr/lib/libjpeg.so.8.0.2
b6083000 b608a000 r-xp /lib/librt-2.20-2014.11.so
b608c000 b60ab000 r-xp /usr/lib/libector.so.1.13.0
b60ae000 b60db000 r-xp /usr/lib/liblua-5.1.so
b60dc000 b616c000 r-xp /usr/lib/libfreetype.so.6.11.3
b6170000 b61ae000 r-xp /usr/lib/libfontconfig.so.1.8.0
b61af000 b61c5000 r-xp /usr/lib/libfribidi.so.0.3.1
b61c6000 b621f000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6222000 b626d000 r-xp /lib/libm-2.20-2014.11.so
b626f000 b6281000 r-xp /usr/lib/libeio.so.1.13.0
b6282000 b6285000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b6286000 b628c000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b628d000 b62b0000 r-xp /usr/lib/libefreet.so.1.13.0
b62b3000 b62de000 r-xp /usr/lib/libeldbus.so.1.13.0
b62df000 b6313000 r-xp /usr/lib/libecore_con.so.1.13.0
b6315000 b631e000 r-xp /usr/lib/libecore_imf.so.1.13.0
b631f000 b6328000 r-xp /usr/lib/libethumb_client.so.1.13.0
b6329000 b633c000 r-xp /usr/lib/libeo.so.1.13.0
b633e000 b6351000 r-xp /usr/lib/libecore_input.so.1.13.0
b6352000 b6359000 r-xp /usr/lib/libecore_file.so.1.13.0
b635a000 b637d000 r-xp /usr/lib/libecore_evas.so.1.13.0
b637e000 b63aa000 r-xp /usr/lib/libeet.so.1.13.0
b63b3000 b641e000 r-xp /usr/lib/libeina.so.1.13.0
b6421000 b6438000 r-xp /usr/lib/libefl.so.1.13.0
b643a000 b65a1000 r-xp /usr/lib/libicuuc.so.51.1
b65af000 b67bb000 r-xp /usr/lib/libicui18n.so.51.1
b67c3000 b6812000 r-xp /usr/lib/libecore_x.so.1.13.0
b6814000 b682e000 r-xp /lib/libgcc_s-4.9.so.1
b6830000 b6834000 r-xp /lib/libcap.so.2.21
b6835000 b687b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b687c000 b6883000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6885000 b68d7000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b68d9000 b6a64000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6a69000 b6b37000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b3a000 b6b3e000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b3f000 b6b4e000 r-xp /usr/lib/libvconf.so.0.2.45
b6b4f000 b6b52000 r-xp /usr/lib/libvasum.so.0.3.1
b6b53000 b6b56000 r-xp /usr/lib/libttrace.so.1.1
b6b58000 b6b5c000 r-xp /usr/lib/libiniparser.so.0
b6b5d000 b6b8d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6b8e000 b6b97000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6b98000 b6bbd000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6bbe000 b6bce000 r-xp /usr/lib/libunwind.so.8.0.1
b6bd8000 b6d86000 r-xp /lib/libc-2.20-2014.11.so
b6d8e000 b6ed1000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6ed3000 b6f2b000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f2c000 b6f60000 r-xp /usr/lib/libsystemd.so.0.4.0
b6f63000 b7037000 r-xp /usr/lib/libedje.so.1.13.0
b703a000 b7066000 r-xp /usr/lib/libecore.so.1.13.0
b7077000 b729d000 r-xp /usr/lib/libevas.so.1.13.0
b72c5000 b72dd000 r-xp /lib/libpthread-2.20-2014.11.so
b72e1000 b765b000 r-xp /usr/lib/libelementary.so.1.13.0
b767b000 b767f000 r-xp /usr/lib/libsmack.so.1.0.0
b7680000 b7689000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b768a000 b768d000 r-xp /usr/lib/libdlog.so.0.0.0
b768e000 b7693000 r-xp /usr/lib/libbundle.so.0.1.22
b7694000 b7697000 r-xp /lib/libdl-2.20-2014.11.so
b7699000 b76be000 r-xp /usr/lib/libaul.so.0.1.0
b76c1000 b76c3000 r-xp /usr/lib/libappsvc.so.0.1.0
b76c4000 b76c9000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b76ca000 b76d1000 r-xp /usr/lib/libappcore-efl.so.1.1
b76d3000 b76d8000 r-xp /usr/lib/libsys-assert.so
b76db000 b76dc000 r-xp [vdso]
b76dc000 b76fe000 r-xp /lib/ld-2.20-2014.11.so
b7700000 b7708000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:13844)
Call Stack Count: 2
 0: (0xb76e499e) [/lib/ld-linux.so.2] + 0x899e
 1: (0xbfe75bd8) (null)
End of Call Stack

Package Information
Package Name: org.example.example
Package ID : org.example.example
Version: 1.0.0
Package Type: tpk
App Name: example
App ID: org.example.example
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
0900 D/rpm-installer(13970): coretpk-installer.c: _coretpk_installer_package_reinstall(4961) > #Current working directory is /.
05-09 02:25:04.123+0900 D/rpm-installer(13970): coretpk-installer.c: _coretpk_installer_verify_signatures(1255) > ------------------------------------------
05-09 02:25:04.123+0900 D/rpm-installer(13970): coretpk-installer.c: _coretpk_installer_verify_signatures(1256) > Verify Signature
05-09 02:25:04.123+0900 D/rpm-installer(13970): coretpk-installer.c: _coretpk_installer_verify_signatures(1257) > ------------------------------------------
05-09 02:25:04.123+0900 D/rpm-installer(13970): coretpk-installer.c: _coretpk_installer_verify_signatures(1258) > root_path=[/opt/usr/apps/org.example.example], pkg_id=[org.example.example]
05-09 02:25:04.123+0900 D/rpm-installer(13970): rpm-installer-signature.c: _ri_process_signaturevalue(533) > SignatureValue, len=[176]
05-09 02:25:04.123+0900 D/rpm-installer(13970): 
05-09 02:25:04.123+0900 D/rpm-installer(13970): MKVXCwrke/Vj+QlneLn6ZTP0kIqQmPXVviIU706rmipg0MK2v3zWqamQuIJXJz+ZpSMJGqC3Lc3c
05-09 02:25:04.123+0900 D/rpm-installer(13970): +iI+F6ifiltuJgOztHYGMDRxgySYwvxBl+/O5o1FC67RBWWijlbPD9+JRX6TNKoELNN4bir24bdI
05-09 02:25:04.123+0900 D/rpm-installer(13970): 7OsMY0jYuX6Ufv9uqmw=
05-09 02:25:04.123+0900 D/rpm-installer(13970): rpm-installer-signature.c: _ri_process_x509certificate(441) > x509certificate, len=[901]
05-09 02:25:04.123+0900 D/rpm-installer(13970): 
05-09 02:25:04.123+0900 D/rpm-installer(13970): MIIClTCCAX2gAwIBAgIGAUX+iaC6MA0GCSqGSIb3DQEBBQUAMFYxGjAYBgNVBAoMEVRpemVuIEFz
05-09 02:25:04.123+0900 D/rpm-installer(13970): c29jaWF0aW9uMRowGAYDVQQLDBFUaXplbiBBc3NvY2lhdGlvbjEcMBoGA1UEAwwTVGl6ZW4gRGV2
05-09 02:25:04.123+0900 D/rpm-installer(13970): ZWxvcGVycyBDQTAeFw0xMjExMDEwMDAwMDBaFw0xOTAxMDEwMDAwMDBaMBExDzANBgNVBAMMBmF1
05-09 02:25:04.123+0900 D/rpm-installer(13970): dGhvcjCBnzANBgkqhkiG9w0BAQEFAAOBjQAwgYkCgYEAgKCL2LL2sZ9wpS9IMO5GKXCSPAz5oKD0
05-09 02:25:04.123+0900 D/rpm-installer(13970): o5HMsGMQThCKmSTFPm9J4qj+MYomrufm2RMA8xp1KyJ79KK2BKg4/DE/5vvWLf1Fh8Jwut9JpkfW
05-09 02:25:04.123+0900 D/rpm-installer(13970): 1b8vNul87ft5NJ7ji5cu7wtQYvxC55BcaXAu3yv0AB0/oXVCRuvluSK5X7lvLHsCAwEAAaMyMDAw
05-09 02:25:04.123+0900 D/rpm-installer(13970): DAYDVR0TAQH/BAIwADALBgNVHQ8EBAMCB4AwEwYDVR0lBAwwCgYIKwYBBQUHAwMwDQYJKoZIhvcN
05-09 02:25:04.123+0900 D/rpm-installer(13970): AQEFBQADggEBADVYof211H9txSG7Bkmcv0erP4gu7uJt61A+4BYu7g2Gv0sVme8NTvu4289Kpdb8
05-09 02:25:04.123+0900 D/rpm-installer(13970): pR5nosBnEL81eHJBuiCopWl1Yf12gc1hx/+nhlD8vdE3idXQUewCACLdaWNxJ5FO6RYZa3Stp6nO
05-09 02:25:04.123+0900 D/rpm-installer(13970): y5U/hTktDpUMlq+ByR7DhjfIFd4D9O4IbQmp7VbsoGrMh8Jqm+q+mSQh6hth0qK2//Z5kHZLQGfi
05-09 02:25:04.123+0900 D/rpm-installer(13970): m1q/W0L6BlE1+zPo8RdeLxEbsoRMYnvOzTYg2dgq5yPT64SCBEamRYeUdIOjbF+y86/1h6NMhmFu
05-09 02:25:04.123+0900 D/rpm-installer(13970): 12NOMj/hg9MfgsXIksRvusRX16blD7uOUz3DwsASa5YnlBdts48=
05-09 02:25:04.123+0900 D/rpm-installer(13970): rpm-installer-signature.c: _ri_process_x509certificate(441) > x509certificate, len=[1124]
05-09 02:25:04.123+0900 D/rpm-installer(13970): 
05-09 02:25:04.123+0900 D/rpm-installer(13970): MIIDOTCCAiGgAwIBAgIBATANBgkqhkiG9w0BAQUFADBYMRowGAYDVQQKDBFUaXplbiBBc3NvY2lh
05-09 02:25:04.123+0900 D/rpm-installer(13970): dGlvbjEaMBgGA1UECwwRVGl6ZW4gQXNzb2NpYXRpb24xHjAcBgNVBAMMFVRpemVuIERldmVsb3Bl
05-09 02:25:04.123+0900 D/rpm-installer(13970): cnMgUm9vdDAeFw0xMjAxMDEwMDAwMDBaFw0yNzAxMDEwMDAwMDBaMFYxGjAYBgNVBAoMEVRpemVu
05-09 02:25:04.123+0900 D/rpm-installer(13970): IEFzc29jaWF0aW9uMRowGAYDVQQLDBFUaXplbiBBc3NvY2lhdGlvbjEcMBoGA1UEAwwTVGl6ZW4g
05-09 02:25:04.123+0900 D/rpm-installer(13970): RGV2ZWxvcGVycyBDQTCCASIwDQYJKoZIhvcNAQEBBQADggEPADCCAQoCggEBANVGhRGmMIUyBA7o
05-09 02:25:04.123+0900 D/rpm-installer(13970): PCz8Sxut6z6HNkF4oDIuzuKaMzRYPeWodwe9O0gmqAkToQHfwg2giRhE5GoPld0fq+OYMMwSasCu
05-09 02:25:04.123+0900 D/rpm-installer(13970): g8dwODx1eDeSYVuOLWRxpAmbTXOsSFi6VoWeyaPEm18JBHvZBsU5YQtgZ6Kp7MqzvQg3pXOxtajj
05-09 02:25:04.123+0900 D/rpm-installer(13970): vyHxiatJl+xXrHgcXC1wgyG3buty7u/Fi2mvKXJ0PRJcCjjK81dqe/Vr20sRUCrbk02zbm5ggFt/
05-09 02:25:04.123+0900 D/rpm-installer(13970): jIEhV8wbFRQpliobc7J4dSTKhFfrqGM8rdd54LYhD7gSI1CFSe16pUXfcVR7FhJztRaiGLnCrwBE
05-09 02:25:04.123+0900 D/rpm-installer(13970): dyTZ248+D4L/qR/D0axb3jcCAwEAAaMQMA4wDAYDVR0TBAUwAwEB/zANBgkqhkiG9w0BAQUFAAOC
05-09 02:25:04.123+0900 D/rpm-installer(13970): AQEAnOXXQ/1O/QTDHyrmQDtFziqPY3xWlJBqJtEqXiT7Y+Ljpe66e+Ee/OjQMlZe8gu21/8cKklH
05-09 02:25:04.123+0900 D/rpm-installer(13970): 95RxjopMWCVedXDUbWdvS2+CdyvVW/quT2E0tjqIzXDekUTYwwhlPWlGxvfj3VsxqSFq3p8Brl04
05-09 02:25:04.123+0900 D/rpm-installer(13970): 1Gx5RKAG
05-09 02:25:04.123+0900 D/PKGMGR  ( 3082): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-2063031222], pkg_type=[tpk], pkgid=[org.example.example], key=[start], value=[update]
05-09 02:25:04.123+0900 D/PKGMGR  ( 2936): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-2063031222], pkg_type=[tpk], pkgid=[org.example.example], key=[start], value=[update]
05-09 02:25:04.123+0900 D/QUICKPANEL( 2936): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.example key:start val:update
05-09 02:25:04.123+0900 D/PKGMGR  ( 3082): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-2063031222], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[30]
05-09 02:25:04.123+0900 D/PKGMGR  ( 2932): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-2063031222], pkg_type=[tpk], pkgid=[org.example.example], key=[start], value=[update]
05-09 02:25:04.123+0900 D/DATA_PROVIDER_MASTER( 2932): pkgmgr.c: start_cb(201) > [SECURE_LOG] [org.example.example] update
05-09 02:25:04.123+0900 D/PKGMGR  ( 2932): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-2063031222], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[30]
05-09 02:25:04.123+0900 D/DATA_PROVIDER_MASTER( 2932): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.example] 30
05-09 02:25:04.123+0900 D/PKGMGR  ( 2936): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-2063031222], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[30]
05-09 02:25:04.123+0900 D/QUICKPANEL( 2936): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.example key:install_percent val:30
05-09 02:25:04.123+0900 D/PKGMGR  ( 2878): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-2063031222], pkg_type=[tpk], pkgid=[org.example.example], key=[start], value=[update]
05-09 02:25:04.123+0900 W/cluster-home( 2878): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[0], package[org.example.example]
05-09 02:25:04.123+0900 D/PKGMGR  ( 2878): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-2063031222], pkg_type=[tpk], pkgid=[org.example.example], key=[start], value=[update]
05-09 02:25:04.123+0900 D/cluster-home( 2878): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[28780003] pkg_type[tpk] package[org.example.example] key[start] val[update] pmsg[(null)]
05-09 02:25:04.123+0900 D/PKGMGR  ( 2878): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-2063031222], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[30]
05-09 02:25:04.123+0900 W/cluster-home( 2878): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[1], package[org.example.example]
05-09 02:25:04.123+0900 D/PKGMGR  ( 2878): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-2063031222], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[30]
05-09 02:25:04.123+0900 D/cluster-home( 2878): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[28780003] pkg_type[tpk] package[org.example.example] key[install_percent] val[30] pmsg[(null)]
05-09 02:25:04.123+0900 D/PKGMGR  (13968): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-2063031222], pkg_type=[tpk], pkgid=[org.example.example], key=[start], value=[update]
05-09 02:25:04.123+0900 D/PKGMGR  (13968): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-2063031222], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[30]
05-09 02:25:04.123+0900 D/PKGMGR  ( 2962): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-2063031222], pkg_type=[tpk], pkgid=[org.example.example], key=[start], value=[update]
05-09 02:25:04.123+0900 D/PKGMGR  ( 2962): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
05-09 02:25:04.123+0900 D/PKGMGR  ( 2940): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-2063031222], pkg_type=[tpk], pkgid=[org.example.example], key=[start], value=[update]
05-09 02:25:04.123+0900 D/PKGMGR  ( 2940): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-2063031222], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[30]
05-09 02:25:04.123+0900 D/PKGMGR  ( 2962): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-2063031222], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[30]
05-09 02:25:04.123+0900 D/PKGMGR  ( 2962): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
05-09 02:25:04.123+0900 D/PKGMGR  ( 3033): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-2063031222], pkg_type=[tpk], pkgid=[org.example.example], key=[start], value=[update]
05-09 02:25:04.123+0900 D/PKGMGR  ( 2763): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[upgrade], req_id=[org.example.example_-2063031222], pkg_type=[tpk], pkgid=[org.example.example], key=[start], value=[update]
05-09 02:25:04.123+0900 D/AUL_AMD ( 2763): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(638) > [SECURE_LOG] pkgid(org.example.example), key(start), value(update)
05-09 02:25:04.123+0900 D/AUL_AMD ( 2763): amd_appinfo.c: __amd_pkgmgrinfo_start_handler(544) > [SECURE_LOG] pkgmgr working for this application(org.example.example)
05-09 02:25:04.123+0900 D/PKGMGR  ( 3033): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-2063031222], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[30]
05-09 02:25:04.123+0900 D/AUL_AMD ( 2763): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(656) > __amd_pkgmgrinfo_start_handler
05-09 02:25:04.123+0900 D/PKGMGR  ( 2938): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-2063031222], pkg_type=[tpk], pkgid=[org.example.example], key=[start], value=[update]
05-09 02:25:04.123+0900 D/ESD     ( 2938): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29380002), pkg_type(tpk), pkgid(org.example.example), key(start), val(update)
05-09 02:25:04.123+0900 D/ESD     ( 2938): esd_main.c: __esd_pkgmgr_event_callback(1720) > update start
05-09 02:25:04.123+0900 D/PKGMGR  ( 2938): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-2063031222], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[30]
05-09 02:25:04.123+0900 D/ESD     ( 2938): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29380002), pkg_type(tpk), pkgid(org.example.example), key(install_percent), val(30)
05-09 02:25:04.133+0900 D/CERT_SVC(13970): cert-service.c: _cert_svc_verify_certificate_with_caflag(188) > [SECURE_LOG] root cert path : /usr/share/cert-svc/certs/code-signing/tizen/tizen-developers-root.pem
05-09 02:25:04.133+0900 D/rpm-installer(13970): rpm-installer.c: _ri_verify_sig_and_cert(1744) > cert_svc_verify() is done successfully. validity=[1]
05-09 02:25:04.133+0900 D/rpm-installer(13970): rpm-installer.c: _ri_verify_sig_and_cert(1758) > cert_svc_get_visibility() returns visibility=[1]
05-09 02:25:04.133+0900 D/rpm-installer(13970): rpm-installer.c: _ri_verify_sig_and_cert(1771) > Root CA cert path=[/usr/share/cert-svc/certs/code-signing/tizen/tizen-developers-root.pem]
05-09 02:25:04.133+0900 D/LAUNCH  (13844): appcore-efl.c: __before_loop(1154) > [example:Application:create:done]
05-09 02:25:04.143+0900 D/APP_CORE(13844): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
05-09 02:25:04.143+0900 E/E17     ( 2725): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x01200002)
05-09 02:25:04.153+0900 D/rpm-installer(13970): rpm-installer.c: __ri_verify_file(336) > valid signature
05-09 02:25:04.153+0900 D/rpm-installer(13970): rpm-installer.c: __ri_get_cert_from_file(1029) > Root CA, len=[1108]
05-09 02:25:04.153+0900 D/rpm-installer(13970): MIIDOzCCAiOgAwIBAgIBADANBgkqhkiG9w0BAQUFADBYMRowGAYDVQQKDBFUaXplbiBBc3NvY2lhdGlvbjEaMBgGA1UECwwRVGl6ZW4gQXNzb2NpYXRpb24xHjAcBgNVBAMMFVRpemVuIERldmVsb3BlcnMgUm9vdDAeFw0xMjAxMDEwMDAwMDBaFw0zMjAxMDEwMDAwMDBaMFgxGjAYBgNVBAoMEVRpemVuIEFzc29jaWF0aW9uMRowGAYDVQQLDBFUaXplbiBBc3NvY2lhdGlvbjEeMBwGA1UEAwwVVGl6ZW4gRGV2ZWxvcGVycyBSb290MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAp2rCwXTYh28vcagXWLIeVtEvXA5EeTR9UnL4Dzyd7hIq8rkxLbIMMOcCrXMTc7bEH2twFaTuXxyKXMW/2c+id3m3Z1B5caCqwSPr72oKPSI4jSkvrAC5W7EHx16M818aG4tQkXIUBhDrtSmH6dFOdt8zGq2fanj1sETfUmXAeLGE7OQYcEb2SoWGXR75Ytfp1LAw/L3luuG/kbzBcrZt1Cv05jfCP575eope6p5p80Gl0tieXyPYhSLVTLwhEdWx18CMaC7IXQo2Bm+JdjDH0Ruh/vTRnjFtmVB+nBOZNVzMHNOPUVFKSgysX/+PlM4jBTvbaTnPCZUkC/O75tYIpwIDAQABoxAwDjAMBgNVHRMEBTADAQH/MA0GCSqGSIb3DQEBBQUAA4IBAQBw95ibcuAiKpAEqBMyTZtOf0okhSi9NYfs/AFIPLH5REnhtQkPmKsvDp21OSdzrFEL42rV94K98QChD9tGO6Mwp1ZHM3No7/PLC3EelOwmn4dr3KPGdjvQNSwKRblGh0Hjn4fI+studFLLv6ldCLIpA/Ssgf9GuUbcjTC8OWBYPVUQ6YoXAcuHbfhr6a
05-09 02:25:04.153+0900 D/rpm-installer(13970): coretpk-installer.c: _coretpk_installer_verify_signatures(1274) > _ri_verify_sig_and_cert(/opt/usr/apps/org.example.example/author-signature.xml) succeed.
05-09 02:25:04.153+0900 D/rpm-installer(13970): rpm-installer-signature.c: _ri_process_signaturevalue(533) > SignatureValue, len=[176]
05-09 02:25:04.153+0900 D/rpm-installer(13970): 
05-09 02:25:04.153+0900 D/rpm-installer(13970): Y6aTkrl92lNvy6Fozvjrs2f83LQecisy6Ew5Qigec9zfACnxxP21t0umH29xmbfSHC9ko6ojunX1
05-09 02:25:04.153+0900 D/rpm-installer(13970): ivnVcaa8YAChMf/GTVGLy86c35ht0+0A4GEiSL/FgceAlTNACsqKcifF6MEkoGATyM1NNMmrVcvJ
05-09 02:25:04.153+0900 D/rpm-installer(13970): KnSouo8vhkN6T0wxxmU=
05-09 02:25:04.153+0900 D/rpm-installer(13970): rpm-installer-signature.c: _ri_process_x509certificate(441) > x509certificate, len=[909]
05-09 02:25:04.153+0900 D/rpm-installer(13970): 
05-09 02:25:04.153+0900 D/rpm-installer(13970): MIICmzCCAgQCCQDXI7WLdVZwiTANBgkqhkiG9w0BAQUFADCBjzELMAkGA1UEBhMCS1IxDjAMBgNV
05-09 02:25:04.153+0900 D/rpm-installer(13970): BAgMBVN1d29uMQ4wDAYDVQQHDAVTdXdvbjEWMBQGA1UECgwNVGl6ZW4gVGVzdCBDQTEiMCAGA1UE
05-09 02:25:04.153+0900 D/rpm-installer(13970): CwwZVGl6ZW4gRGlzdHJpYnV0b3IgVGVzdCBDQTEkMCIGA1UEAwwbVGl6ZW4gUHVibGljIERpc3Ry
05-09 02:25:04.153+0900 D/rpm-installer(13970): aWJ1dG9yIENBMB4XDTEyMTAyOTEzMDMwNFoXDTIyMTAyNzEzMDMwNFowgZMxCzAJBgNVBAYTAktS
05-09 02:25:04.153+0900 D/rpm-installer(13970): MQ4wDAYDVQQIDAVTdXdvbjEOMAwGA1UEBwwFU3V3b24xFjAUBgNVBAoMDVRpemVuIFRlc3QgQ0Ex
05-09 02:25:04.153+0900 D/rpm-installer(13970): IjAgBgNVBAsMGVRpemVuIERpc3RyaWJ1dG9yIFRlc3QgQ0ExKDAmBgNVBAMMH1RpemVuIFB1Ymxp
05-09 02:25:04.153+0900 D/rpm-installer(13970): YyBEaXN0cmlidXRvciBTaWduZXIwgZ8wDQYJKoZIhvcNAQEBBQADgY0AMIGJAoGBALtMvlc5hENK
05-09 02:25:04.153+0900 D/rpm-installer(13970): 90ZdA+y66+Sy0enD1gpZDBh5T9RP0oRsptJv5jjNTseQbQi0SZOdOXb6J7iQdlBCtR343RpIEz8H
05-09 02:25:04.153+0900 D/rpm-installer(13970): mrBy7mSY7mgwoU4EPpp4CTSUeAuKcmvrNOngTp5Hv7Ngf02TTHOLK3hZLpGayaDviyNZB5PdqQdB
05-09 02:25:04.153+0900 D/rpm-installer(13970): hokKjzAzAgMBAAEwDQYJKoZIhvcNAQEFBQADgYEAvGp1gxxAIlFfhJH1efjb9BJK/rtRkbYn9+Ez
05-09 02:25:04.153+0900 D/rpm-installer(13970): GEbEULg1svsgnyWisFimI3uFvgI/swzr1eKVY3Sc8MQ3+Fdy3EkbDZ2+WAubhcEkorTWjzWz2fL1
05-09 02:25:04.153+0900 D/rpm-installer(13970): vKaYjeIsuEX6TVRUugHWudPzcEuQRLQf8ibZWjbQdBmpeQYBMg5x+xKLCJc=
05-09 02:25:04.153+0900 D/rpm-installer(13970): rpm-installer-signature.c: _ri_process_x509certificate(441) > x509certificate, len=[942]
05-09 02:25:04.153+0900 D/rpm-installer(13970): 
05-09 02:25:04.153+0900 D/rpm-installer(13970): MIICtDCCAh2gAwIBAgIJAMDbehElPNKvMA0GCSqGSIb3DQEBBQUAMIGVMQswCQYDVQQGEwJLUjEO
05-09 02:25:04.153+0900 D/rpm-installer(13970): MAwGA1UECAwFU3V3b24xDjAMBgNVBAcMBVN1d29uMRYwFAYDVQQKDA1UaXplbiBUZXN0IENBMSMw
05-09 02:25:04.153+0900 D/rpm-installer(13970): IQYDVQQLDBpUVGl6ZW4gRGlzdHJpYnV0b3IgVGVzdCBDQTEpMCcGA1UEAwwgVGl6ZW4gUHVibGlj
05-09 02:25:04.153+0900 D/rpm-installer(13970): IERpc3RyaWJ1dG9yIFJvb3QgQ0EwHhcNMTIxMDI5MTMwMjUwWhcNMjIxMDI3MTMwMjUwWjCBjzEL
05-09 02:25:04.153+0900 D/rpm-installer(13970): MAkGA1UEBhMCS1IxDjAMBgNVBAgMBVN1d29uMQ4wDAYDVQQHDAVTdXdvbjEWMBQGA1UECgwNVGl6
05-09 02:25:04.153+0900 D/rpm-installer(13970): ZW4gVGVzdCBDQTEiMCAGA1UECwwZVGl6ZW4gRGlzdHJpYnV0b3IgVGVzdCBDQTEkMCIGA1UEAwwb
05-09 02:25:04.153+0900 D/rpm-installer(13970): VGl6ZW4gUHVibGljIERpc3RyaWJ1dG9yIENBMIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQDe
05-09 02:25:04.153+0900 D/rpm-installer(13970): OTS/3nXvkDEmsFCJIvRlQ3RKDcxdWJJp625pFqHdmoJBdV+x6jl1raGK2Y1sp2Gdvpjc/z92yzAp
05-09 02:25:04.153+0900 D/rpm-installer(13970): bE/UVLPh/tRNZPeGhzU4ejDDm7kzdr2f7Ia0U98K+OoY12ucwg7TYNItj9is7Cj4blGfuMDzd2ah
05-09 02:25:04.153+0900 D/rpm-installer(13970): 2AgnCGlwNwV/pv+uVQIDAQABoxAwDjAMBgNVHRMEBTADAQH/MA0GCSqGSIb3DQEBBQUAA4GBACqJ
05-09 02:25:04.153+0900 D/rpm-installer(13970): KO33YdoGudwanZIxMdXuxnnD9R6u72ltKk1S4zPfMJJv482CRGCI4FK6djhlsI4i0Lt1SVIJEed+
05-09 02:25:04.153+0900 D/rpm-installer(13970): yc3qckGm19dW+4xdlkekon7pViEBWuyHw8OWv3RXtTum1+PGHjBJ2eYY4ZKIpz73U/1NC16sTB/0
05-09 02:25:04.153+0900 D/rpm-installer(13970): VhfnkHwPl
05-09 02:25:04.163+0900 D/CERT_SVC(13970): cert-service.c: _cert_svc_verify_certificate_with_caflag(188) > [SECURE_LOG] root cert path : /usr/share/cert-svc/certs/code-signing/tizen/tizen-distributor-root-ca-public.pem
05-09 02:25:04.163+0900 D/rpm-installer(13970): rpm-installer.c: _ri_verify_sig_and_cert(1744) > cert_svc_verify() is done successfully. validity=[1]
05-09 02:25:04.163+0900 D/rpm-installer(13970): rpm-installer.c: _ri_verify_sig_and_cert(1758) > cert_svc_get_visibility() returns visibility=[64]
05-09 02:25:04.163+0900 D/rpm-installer(13970): rpm-installer.c: _ri_verify_sig_and_cert(1771) > Root CA cert path=[/usr/share/cert-svc/certs/code-signing/tizen/tizen-distributor-root-ca-public.pem]
05-09 02:25:04.173+0900 D/rpm-installer(13970): rpm-installer.c: __ri_verify_file(336) > valid signature
05-09 02:25:04.183+0900 D/rpm-installer(13970): rpm-installer.c: __ri_get_cert_from_file(1029) > Root CA, len=[908]
05-09 02:25:04.183+0900 D/rpm-installer(13970): MIICozCCAgwCCQD9XW6kNg4bbjANBgkqhkiG9w0BAQUFADCBlTELMAkGA1UEBhMCS1IxDjAMBgNVBAgMBVN1d29uMQ4wDAYDVQQHDAVTdXdvbjEWMBQGA1UECgwNVGl6ZW4gVGVzdCBDQTEjMCEGA1UECwwaVFRpemVuIERpc3RyaWJ1dG9yIFRlc3QgQ0ExKTAnBgNVBAMMIFRpemVuIFB1YmxpYyBEaXN0cmlidXRvciBSb290IENBMB4XDTEyMTAyNjA4MDAyN1oXDTIyMTAyNDA4MDAyN1owgZUxCzAJBgNVBAYTAktSMQ4wDAYDVQQIDAVTdXdvbjEOMAwGA1UEBwwFU3V3b24xFjAUBgNVBAoMDVRpemVuIFRlc3QgQ0ExIzAhBgNVBAsMGlRUaXplbiBEaXN0cmlidXRvciBUZXN0IENBMSkwJwYDVQQDDCBUaXplbiBQdWJsaWMgRGlzdHJpYnV0b3IgUm9vdCBDQTCBnzANBgkqhkiG9w0BAQEFAAOBjQAwgYkCgYEA8o0kPY1U9El1BbBUF1k4jCq6mH8a6MmDJdjgsz+hILAYsPWimRTXUcW8GAUWhZWgm1Fbb49xWcasA8b4bIJabC/6hLb8uWiozzpRXyQJbe7k//RocskRqDmFOky8ANFsCCww72/Xbq8BFK1sxlGdmOWQiGwDWBDlS2Lw1XOMqb0CAwEAATANBgkqhkiG9w0BAQUFAAOBgQBUotZqTNFr+SNyqeZqhOToRsg3ojN1VJUa07qdlVo5I1UObSE+UTJPJ0NtSj7OyTY7fF3E4xzUv/w8aUoabQP1erEmztY/AVD+phHaPytkZ/Dx+zDZ1u5e9bKm5zfY4dQs/A53zDQta5a/NkZOEF97Dj3+bzAh2bP7KOszlocFYw==
05-09 02:25:04.183+0900 D/rpm-installer(13970): coretpk-installer.c: _coretpk_installer_verify_signatures(1284) > _ri_verify_sig_and_cert(/opt/usr/apps/org.example.example/signature1.xml) succeed.
05-09 02:25:04.183+0900 D/rpm-installer(13970): coretpk-installer.c: _coretpk_installer_package_reinstall(4980) > signature and certificate verifying success
05-09 02:25:04.183+0900 D/PKGMGR  (13970): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(13970), zone(host), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(60)
05-09 02:25:04.183+0900 D/PKGMGR  (13970): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(13970), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(60)
05-09 02:25:04.183+0900 D/PKGMGR  (13970): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr_status), signal_name(status)
05-09 02:25:04.183+0900 D/PKGMGR_INSTALLER(13970): pkgmgr_installer.c: __send_event(112) > option is pkgid[org.example.example] key[install_percent] value[60]
05-09 02:25:04.183+0900 D/PKGMGR  (13970): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(13970), zone(host), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(60)
05-09 02:25:04.183+0900 D/PKGMGR  (13970): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(13970), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(60)
05-09 02:25:04.183+0900 D/PKGMGR  (13970): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr.install.progress), signal_name(install_progress)
05-09 02:25:04.183+0900 E/PKGMGR_CERT(13970): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
05-09 02:25:04.183+0900 D/PKGMGR  ( 3033): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-2063031222], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
05-09 02:25:04.183+0900 E/PKGMGR_CERT(13970): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 18
05-09 02:25:04.183+0900 E/PKGMGR_CERT(13970): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 18
05-09 02:25:04.183+0900 E/PKGMGR_CERT(13970): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 10 3
05-09 02:25:04.183+0900 E/PKGMGR_CERT(13970): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 7 6
05-09 02:25:04.183+0900 E/PKGMGR_CERT(13970): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 8 6
05-09 02:25:04.183+0900 E/PKGMGR_CERT(13970): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 9 6
05-09 02:25:04.183+0900 D/PKGMGR  ( 2936): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-2063031222], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
05-09 02:25:04.183+0900 D/QUICKPANEL( 2936): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.example key:install_percent val:60
05-09 02:25:04.183+0900 D/PKGMGR  (13968): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-2063031222], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
05-09 02:25:04.183+0900 D/PKGMGR  ( 2962): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-2063031222], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
05-09 02:25:04.183+0900 D/PKGMGR  ( 2962): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
05-09 02:25:04.183+0900 D/PKGMGR  ( 3082): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-2063031222], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
05-09 02:25:04.183+0900 D/PKGMGR  ( 2938): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-2063031222], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
05-09 02:25:04.183+0900 D/PKGMGR  ( 2932): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-2063031222], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
05-09 02:25:04.183+0900 D/ESD     ( 2938): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29380002), pkg_type(tpk), pkgid(org.example.example), key(install_percent), val(60)
05-09 02:25:04.183+0900 D/DATA_PROVIDER_MASTER( 2932): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.example] 60
05-09 02:25:04.183+0900 D/PKGMGR  ( 2940): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-2063031222], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
05-09 02:25:04.193+0900 D/PKGMGR  ( 2878): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-2063031222], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
05-09 02:25:04.193+0900 W/cluster-home( 2878): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[1], package[org.example.example]
05-09 02:25:04.193+0900 D/PKGMGR  ( 2878): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-2063031222], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[60]
05-09 02:25:04.193+0900 D/cluster-home( 2878): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[28780003] pkg_type[tpk] package[org.example.example] key[install_percent] val[60] pmsg[(null)]
05-09 02:25:04.203+0900 E/PKGMGR_CERT(13970): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
05-09 02:25:04.203+0900 D/rpm-installer(13970): rpm-installer-privilege.c: _ri_privilege_unregister_package(85) > [smack] app_uninstall(org.example.example), result=[0]
05-09 02:25:04.213+0900 D/rpm-installer(13970): rpm-installer-privilege.c: _ri_privilege_register_package(65) > [smack] app_install(org.example.example), result=[0]
05-09 02:25:04.213+0900 D/rpm-installer(13970): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example, 5, _), result=[0]
05-09 02:25:04.223+0900 D/rpm-installer(13970): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/shared, 5, _), result=[0]
05-09 02:25:04.223+0900 E/E17     ( 2725): e_border.c: e_border_show(2088) > BD_SHOW(0x01200002)
05-09 02:25:04.223+0900 D/rpm-installer(13970): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/shared/res, 5, _), result=[0]
05-09 02:25:04.233+0900 D/rpm-installer(13970): rpm-installer-privilege.c: _ri_privilege_setup_path(117) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/shared/data, 2), result=[0]
05-09 02:25:04.233+0900 D/rpm-installer(13970): coretpk-installer.c: _coretpk_installer_get_smack_label_access(1101) > [smack] get_smack_label, path=[/opt/usr/apps/org.example.example/shared/data], label=[$1$org.exam$u8BwfYMV9u%MYLLw2JGhj1]
05-09 02:25:04.233+0900 D/rpm-installer(13970): coretpk-installer.c: _coretpk_installer_set_smack_label_access(1088) > [smack] set_smack_label, path=[/opt/usr/apps/org.example.example/shared/cache], label=[$1$org.exam$u8BwfYMV9u%MYLLw2JGhj1]
05-09 02:25:04.233+0900 D/APP_CORE(13844): appcore.c: __aul_handler(587) > [APP 13844]     AUL event: AUL_START
05-09 02:25:04.233+0900 I/APP_CORE(13844): appcore-efl.c: __do_app(496) > [APP 13844] Event: RESET State: CREATED
05-09 02:25:04.233+0900 D/APP_CORE(13844): appcore-efl.c: __do_app(527) > [APP 13844] RESET
05-09 02:25:04.233+0900 D/LAUNCH  (13844): appcore-efl.c: __do_app(529) > [example:Application:reset:start]
05-09 02:25:04.233+0900 D/APP_CORE(13844): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
05-09 02:25:04.233+0900 D/APP_CORE(13844): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
05-09 02:25:04.233+0900 I/CAPI_APPFW_APPLICATION(13844): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
05-09 02:25:04.233+0900 D/LAUNCH  (13844): appcore-efl.c: __do_app(544) > [example:Application:reset:done]
05-09 02:25:04.233+0900 D/APP_CORE(13844): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : org.tizen.homescreen
05-09 02:25:04.243+0900 E/EFL     (13844): edje<13844> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-09 02:25:04.243+0900 E/EFL     (13844): By the power of Grayskull, your previous Embryo stack is now broken!
05-09 02:25:04.243+0900 E/EFL     (13844): edje<13844> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-09 02:25:04.243+0900 E/EFL     (13844): By the power of Grayskull, your previous Embryo stack is now broken!
05-09 02:25:04.243+0900 E/EFL     (13844): edje<13844> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-09 02:25:04.243+0900 E/EFL     (13844): By the power of Grayskull, your previous Embryo stack is now broken!
05-09 02:25:04.243+0900 E/EFL     (13844): edje<13844> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-09 02:25:04.243+0900 E/EFL     (13844): By the power of Grayskull, your previous Embryo stack is now broken!
05-09 02:25:04.243+0900 E/EFL     (13844): edje<13844> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-09 02:25:04.243+0900 E/EFL     (13844): By the power of Grayskull, your previous Embryo stack is now broken!
05-09 02:25:04.243+0900 E/rpm-installer(13970): installer-util.c: _installer_util_get_configuration_value(418) > [signature]=[on]
05-09 02:25:04.253+0900 D/rpm-installer(13970): coretpk-installer.c: _coretpk_installer_get_group_id(2472) > encoding done, len=[28]
05-09 02:25:04.253+0900 D/rpm-installer(13970): coretpk-installer.c: _coretpk_installer_apply_smack(2575) > groupid = [lRCBhlfBM8hN+lAnIV9z4vodWRE=] for shared/trusted.
05-09 02:25:04.253+0900 W/APP_CORE(13844): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1200002
05-09 02:25:04.253+0900 D/APP_CORE(13844): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:1200002
05-09 02:25:04.253+0900 D/APP_CORE(13844): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
05-09 02:25:04.263+0900 D/AUL     (13844): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
05-09 02:25:04.263+0900 D/AUL_AMD ( 2763): amd_request.c: __request_handler(838) > __request_handler: 34
05-09 02:25:04.273+0900 D/rpm-installer(13970): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/shared/trusted, 1, lRCBhlfBM8hN+lAnIV9z4vodWRE=), result=[0]
05-09 02:25:04.283+0900 D/rpm-installer(13970): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/bin, 0, org.example.example), result=[0]
05-09 02:25:04.283+0900 D/rpm-installer(13970): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/data, 0, org.example.example), result=[0]
05-09 02:25:04.283+0900 W/PROCESSMGR( 2725): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=13844
05-09 02:25:04.293+0900 D/rpm-installer(13970): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/lib, 0, org.example.example), result=[0]
05-09 02:25:04.293+0900 D/rpm-installer(13970): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/res, 0, org.example.example), result=[0]
05-09 02:25:04.303+0900 E/EFL     ( 2725): eo<2725> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-09 02:25:04.303+0900 E/EFL     ( 2725): eo<2725> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-09 02:25:04.313+0900 D/rpm-installer(13970): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/cache, 0, org.example.example), result=[0]
05-09 02:25:04.313+0900 D/rpm-installer(13970): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/tizen-manifest.xml, 0, org.example.example), result=[0]
05-09 02:25:04.333+0900 D/rpm-installer(13970): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/author-signature.xml, 0, org.example.example), result=[0]
05-09 02:25:04.333+0900 D/AUL_AMD ( 2763): amd_request.c: __request_handler(838) > __request_handler: 15
05-09 02:25:04.333+0900 D/PKGMGR_INFO( 2763): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-09 02:25:04.333+0900 D/PKGMGR_INFO( 2763): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-09 02:25:04.333+0900 D/AUL_AMD ( 2763): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 13844 is org.example.example
05-09 02:25:04.333+0900 D/AUL_AMD ( 2763): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 13844 : 0
05-09 02:25:04.333+0900 D/AUL     ( 2940): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
05-09 02:25:04.343+0900 D/rpm-installer(13970): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/usr/apps/org.example.example/signature1.xml, 0, org.example.example), result=[0]
05-09 02:25:04.343+0900 D/rpm-installer(13970): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.example, /opt/share/packages/org.example.example.xml, 0, org.example.example), result=[0]
05-09 02:25:04.353+0900 D/rpm-installer(13970): rpm-installer-privilege.c: _ri_privilege_set_package_version(75) > [smack] app[org.example.example] version set to [2.4] result=[0]
05-09 02:25:04.353+0900 D/rpm-installer(13970): rpm-installer.c: _ri_apply_privilege(1924) > api-version[2.4] fot privilege has done successfully.
05-09 02:25:04.363+0900 D/rpm-installer(13970): rpm-installer-privilege.c: _ri_privilege_enable_permissions(106) > [smack] app_enable_permissions(org.example.example, 7), result=[0]
05-09 02:25:04.363+0900 D/rpm-installer(13970): coretpk-installer.c: _coretpk_installer_package_reinstall(5083) > #permission applying success.
05-09 02:25:04.363+0900 D/PKGMGR  (13970): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(13970), zone(host), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(100)
05-09 02:25:04.363+0900 D/PKGMGR  (13970): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(13970), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(100)
05-09 02:25:04.363+0900 D/PKGMGR  (13970): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr_status), signal_name(status)
05-09 02:25:04.363+0900 D/PKGMGR_INSTALLER(13970): pkgmgr_installer.c: __send_event(112) > option is pkgid[org.example.example] key[install_percent] value[100]
05-09 02:25:04.363+0900 D/PKGMGR  (13970): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(13970), zone(host), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(100)
05-09 02:25:04.363+0900 D/PKGMGR  (13970): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(13970), pkg_typ(tpk), pkg_id(org.example.example), key(install_percent), val(100)
05-09 02:25:04.363+0900 D/PKGMGR  (13970): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr.install.progress), signal_name(install_progress)
05-09 02:25:04.363+0900 D/rpm-installer(13970): coretpk-installer.c: _coretpk_installer_package_reinstall(5096) > _coretpk_installer_package_reinstall(org.example.example) is done.
05-09 02:25:04.363+0900 D/PKGMGR  (13970): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(13970), zone(host), pkg_typ(tpk), pkg_id(org.example.example), key(end), val(ok)
05-09 02:25:04.363+0900 D/PKGMGR  (13970): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(13970), pkg_typ(tpk), pkg_id(org.example.example), key(end), val(ok)
05-09 02:25:04.363+0900 D/PKGMGR  (13970): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr_status), signal_name(status)
05-09 02:25:04.363+0900 D/PKGMGR_INSTALLER(13970): pkgmgr_installer.c: __send_event(112) > option is pkgid[org.example.example] key[end] value[ok]
05-09 02:25:04.363+0900 D/PKGMGR  (13970): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(273) > send signal : pid(13970), zone(host), pkg_typ(tpk), pkg_id(org.example.example), key(end), val(ok)
05-09 02:25:04.363+0900 D/PKGMGR  (13970): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(277) > send signal : pid(13970), pkg_typ(tpk), pkg_id(org.example.example), key(end), val(ok)
05-09 02:25:04.363+0900 D/PKGMGR  (13970): comm_status_broadcast_server_dbus.c: comm_status_broadcast_server_send_signal(279) > send signal : interface_name(org.tizen.pkgmgr.upgrade), signal_name(upgrade)
05-09 02:25:04.373+0900 D/PKGMGR  ( 3082): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-2063031222], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
05-09 02:25:04.373+0900 D/PKGMGR  ( 2936): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-2063031222], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
05-09 02:25:04.373+0900 D/QUICKPANEL( 2936): uninstall.c: _pkgmgr_event_cb(88) > [SECURE_LOG] [_pkgmgr_event_cb : 88] pkg:org.example.example key:install_percent val:100
05-09 02:25:04.373+0900 D/PKGMGR  ( 2940): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-2063031222], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
05-09 02:25:04.373+0900 D/PKGMGR  ( 2962): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-2063031222], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
05-09 02:25:04.373+0900 D/PKGMGR  ( 2962): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
05-09 02:25:04.373+0900 D/PKGMGR  (13968): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-2063031222], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
05-09 02:25:04.373+0900 D/PKGMGR  ( 3033): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-2063031222], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
05-09 02:25:04.373+0900 D/PKGMGR  ( 2938): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-2063031222], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
05-09 02:25:04.373+0900 D/ESD     ( 2938): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29380002), pkg_type(tpk), pkgid(org.example.example), key(install_percent), val(100)
05-09 02:25:04.373+0900 D/PKGMGR  ( 2878): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-2063031222], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
05-09 02:25:04.373+0900 W/cluster-home( 2878): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[1], package[org.example.example]
05-09 02:25:04.373+0900 D/PKGMGR  ( 2878): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-2063031222], pkg_type=[tpk], pkgid=[org.example.example], key=[install_percent], value=[100]
05-09 02:25:04.373+0900 D/cluster-home( 2878): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[28780003] pkg_type[tpk] package[org.example.example] key[install_percent] val[100] pmsg[(null)]
05-09 02:25:04.383+0900 D/PKGMGR  ( 3033): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-2063031222], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-09 02:25:04.383+0900 D/ISF_PANEL_EFL( 3033): isf_panel_efl.cpp: _package_manager_event_cb(1288) > type=tpk package=org.example.example event_type=UPDATE event_state=COMPLETED progress=100 error=0
05-09 02:25:04.383+0900 D/PKGMGR  ( 2938): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-2063031222], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-09 02:25:04.383+0900 D/ESD     ( 2938): esd_main.c: __esd_pkgmgr_event_callback(1710) > req_id(29380002), pkg_type(tpk), pkgid(org.example.example), key(end), val(ok)
05-09 02:25:04.383+0900 D/ESD     ( 2938): esd_main.c: __esd_pkgmgr_event_callback(1728) > install end (ok)
05-09 02:25:04.383+0900 D/PKGMGR  ( 2962): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-2063031222], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-09 02:25:04.383+0900 D/PKGMGR  ( 2962): pkgmgr.c: __status_callback(441) > call event_cb_with_zone
05-09 02:25:04.383+0900 D/PKGMGR  ( 2878): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-2063031222], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-09 02:25:04.383+0900 W/cluster-home( 2878): widget-data-provider.cpp: WidgetDataProviderPackageManagerEventCB(376) > [SECURE_LOG]  PackageManager Event type[2], state[2], package[org.example.example]
05-09 02:25:04.383+0900 D/cluster-home( 2878): widget-data-provider.cpp: PackageUpdated(2160) >  No boxes that pkgname is[org.example.example]
05-09 02:25:04.383+0900 D/PKGMGR  ( 2878): comm_client_gdbus.c: _on_signal_handle_filter(353) > [SECURE_LOG] signal_name=[status], req_id=[org.example.example_-2063031222], pkg_type=[tpk], pkgid=[org.example.example], key=[end], value=[ok]
05-09 02:25:04.383+0900 D/cluster-home( 2878): mainmenu-package-manager.cpp: OnClientListenCb(436) >  req_id[28780003] pkg_type[tpk] package[org.example.example] key[end] val[ok] pmsg[(null)]
05-09 02:25:04.383+0900 E/cluster-home( 2878): mainmenu-package-manager.cpp: OnClientListenCb(463) >  #Step 1
05-09 02:25:04.383+0900 E/cluster-home( 2878): mainmenu-package-manager.cpp: OnClientListenCb(467) >  #Step 2
05-09 02:25:04.383+0900 E/cluster-home( 2878): mainmenu-package-manager.cpp: _GetAppIds(334) >  BEGIN
05-09 02:25:04.383+0900 W/ISF_PANEL_EFL( 3033): isf_panel_efl.cpp: _package_manager_event_cb(1380) > isf_db_select_appids_by_pkgid returned 0.
05-09 02:25:04.383+0900 D/cluster-home( 2878): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(220) >  NoDisplay [0]
05-09 02:25:04.383+0900 D/cluster-home( 2878): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(225) >  app Id [org.example.example]
05-09 02:25:04.383+0900 E/cluster-home( 2878): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(236) >  ##### [org.example.example]
05-09 02:25:04.383+0900 E/cluster-home( 2878): mainmenu-package-manager.cpp: _GetAppIds(355) >  ##### [org.example.example]
05-09 02:25:04.383+0900 E/cluster-home( 2878): mainmenu-package-manager.cpp: _GetAppIds(359) >  END
05-09 02:25:04.383+0900 E/cluster-home( 2878): mainmenu-package-manager.cpp: _DoPkgJob(387) >  #Step 3 size[1]
05-09 02:25:04.383+0900 E/cluster-home( 2878): mainmenu-package-manager.cpp: _DoPkgJob(391) >  appId[org.example.example]
05-09 02:25:04.383+0900 E/cluster-home( 2878): mainmenu-package-manager.cpp: _GetAppInfo(848) >  AppId[org.example.example] Name[example] Icon[/opt/usr/apps/org.example.example/shared/res/example.png] enable[1] system[0]
05-09 02:25:04.383+0900 D/cluster-home( 2878): mainmenu-presenter.cpp: OnAppUpdated(337) >  pAppId [org.example.example]
05-09 02:25:04.393+0900 D/cluster-home( 2878): mainmenu-data-manager.cpp: GetBoxDataByAppId(1832) >  BEGIN, strAppId: org.example.example
05-09 02:25:04.393+0900 D/cluster-home( 2878): mainmenu-data-manager.cpp: GetBoxDataByAppId(1874) >  nId[13], isFolder[0], pageId[1], col[1], row[4], appId[org.example.example], name[example], menuId[1], isPreload[0] isPreload[0]
05-09 02:25:04.393+0900 D/cluster-home( 2878): mainmenu-data-manager.cpp: GetBoxDataByAppId(1881) >  DONE
05-09 02:25:04.393+0900 E/cluster-home( 2878): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.example] Name[example] Icon[/opt/usr/apps/org.example.example/shared/res/example.png] enable[1] system[0]
05-09 02:25:04.393+0900 D/cluster-home( 2878): mainmenu-presenter.cpp: OnAppUpdated(364) >  name [example]
05-09 02:25:04.393+0900 D/cluster-home( 2878): mainmenu-data-manager.cpp: GetMenuBoxData(1241) >  BEGIN
05-09 02:25:04.393+0900 D/cluster-home( 2878): mainmenu-data-manager.cpp: GetMenuBoxData(1291) >  DONE
05-09 02:25:04.393+0900 D/test-log( 2878): mainmenu-box-impl.cpp: UpdateBoxData(812) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.example/shared/res/example.png], New icon path[/opt/usr/apps/org.example.example/shared/res/example.png]!!!!!
05-09 02:25:04.393+0900 D/cluster-home( 2878): mainmenu-data-manager.cpp: UpdateBoxData(853) >  Query [UPDATE boxes set isFolder = 0, pageId = 1, appId = $appId, name = $name, col = 1, row = 4, isPreload = 0, isSystem = 0 WHERE boxId = 13]
05-09 02:25:04.393+0900 W/CRASH_MANAGER(13978): worker.c: worker_job(1204) > 1113844657861149426430
