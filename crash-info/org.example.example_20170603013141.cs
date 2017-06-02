S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: example
PID: 8756
Date: 2017-06-03 01:31:41+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 8756, uid 5000)

Register Information
r0   = 0x8000ca66, r1   = 0x372c3034
r2   = 0xb3f36000, r3   = 0xb3f36020
r4   = 0x8001b6dc, r5   = 0xbe9b22a0
r6   = 0xb2821e61, r7   = 0xbe9b2128
r8   = 0x8001b6dc, r9   = 0xb5f18708
r10  = 0xb7de0930, fp   = 0xbe9b227c
ip   = 0xb6008120, sp   = 0xbe9b20e8
lr   = 0xb5fccbd9, pc   = 0xb2821e8a
cpsr = 0x800f0030

Memory Information
MemTotal:   987012 KB
MemFree:     64772 KB
Buffers:     10032 KB
Cached:     100600 KB
VmPeak:     102892 KB
VmSize:     100372 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       23040 KB
VmRSS:       23040 KB
VmData:      26304 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35728 KB
VmPTE:          82 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 8756 TID = 8756
8756 8757 9215 

Maps Information
b1b95000 b1b9d000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1bae000 b1baf000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1bbf000 b1bd3000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1be7000 b1be8000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1bf8000 b1bfb000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c0c000 b1c0d000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c1d000 b1c1f000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c2f000 b1c31000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c41000 b1c51000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c61000 b1c6d000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c7f000 b247e000 rw-p [stack:9215]
b27af000 b27b6000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27c7000 b27cf000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b27df000 b27f4000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b2806000 b280c000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b281c000 b2824000 r-xp /opt/usr/apps/org.example.example/bin/example
b297c000 b2a5f000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a96000 b2abe000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2ad0000 b32cf000 rw-p [stack:8757]
b32cf000 b32d1000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32e1000 b32eb000 r-xp /lib/libnss_files-2.20-2014.11.so
b32fc000 b3305000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3316000 b3327000 r-xp /lib/libnsl-2.20-2014.11.so
b333a000 b3340000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3351000 b3352000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b337a000 b3381000 r-xp /usr/lib/libminizip.so.1.0.0
b3391000 b3396000 r-xp /usr/lib/libstorage.so.0.1
b33a6000 b3405000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b341b000 b342f000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b343f000 b3483000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3493000 b349b000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b34ab000 b34db000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b34ee000 b35a7000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b35bb000 b360e000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b361f000 b363a000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b364a000 b370b000 r-xp /usr/lib/libprotobuf.so.9.0.1
b371e000 b372e000 r-xp /usr/lib/libefl-assist.so.0.1.0
b373e000 b374b000 r-xp /usr/lib/libmdm-common.so.1.0.98
b375c000 b3763000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3773000 b37b4000 r-xp /usr/lib/libmdm.so.1.2.12
b37c4000 b37cc000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37db000 b37eb000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b380c000 b386c000 r-xp /usr/lib/libasound.so.2.0.0
b387e000 b3881000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3891000 b3894000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b38a4000 b38a9000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b38b9000 b38ba000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b38ca000 b38d5000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38e9000 b38f0000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3900000 b3906000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3916000 b391b000 r-xp /usr/lib/libmmfsession.so.0.0.1
b392b000 b3946000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3956000 b395d000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b396d000 b3970000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3981000 b39af000 r-xp /usr/lib/libidn.so.11.5.44
b39bf000 b39d5000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39e6000 b39f0000 r-xp /usr/lib/libcares.so.2.1.0
b3a00000 b3a0a000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3a1a000 b3a1c000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a2c000 b3a2d000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a3d000 b3a41000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a52000 b3a7a000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a8b000 b3ab4000 r-xp /usr/lib/libturbojpeg.so
b3ad4000 b3ada000 r-xp /usr/lib/libgif.so.4.1.6
b3aea000 b3b30000 r-xp /usr/lib/libcurl.so.4.3.0
b3b41000 b3b62000 r-xp /usr/lib/libexif.so.12.3.3
b3b7d000 b3b92000 r-xp /usr/lib/libtts.so
b3ba3000 b3bab000 r-xp /usr/lib/libfeedback.so.0.1.4
b3bbb000 b3c81000 r-xp /usr/lib/libdali-core.so.0.0.0
b3ca1000 b3d99000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3db8000 b3e86000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e9d000 b3e9f000 r-xp /usr/lib/libboost_system.so.1.51.0
b3eaf000 b3eb5000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3ec5000 b3ee8000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3ef9000 b3efb000 r-xp /usr/lib/libappsvc.so.0.1.0
b3f0b000 b3f0d000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f1e000 b3f23000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f3a000 b3f3c000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f4c000 b3f53000 r-xp /usr/lib/libsensord-share.so
b3f63000 b3f7b000 r-xp /usr/lib/libsensor.so.1.1.0
b3f8c000 b3f8f000 r-xp /usr/lib/libXv.so.1.0.0
b3f9f000 b3fa4000 r-xp /usr/lib/libutilX.so.1.1.0
b3fb4000 b3fb9000 r-xp /usr/lib/libappcore-common.so.1.1
b3fc9000 b3fd0000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3fe3000 b3fe7000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3ff8000 b40d6000 r-xp /usr/lib/libCOREGL.so.4.0
b40f6000 b40f9000 r-xp /usr/lib/libuuid.so.1.3.0
b4109000 b4120000 r-xp /usr/lib/libblkid.so.1.1.0
b4131000 b4133000 r-xp /usr/lib/libXau.so.6.0.0
b4143000 b418a000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b419c000 b41a2000 r-xp /usr/lib/libjson-c.so.2.0.1
b41b3000 b41b7000 r-xp /usr/lib/libogg.so.0.7.1
b41c7000 b41e9000 r-xp /usr/lib/libvorbis.so.0.4.3
b41f9000 b42dd000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42f9000 b42fc000 r-xp /usr/lib/libEGL.so.1.4
b430d000 b4313000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4323000 b4325000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4335000 b4342000 r-xp /usr/lib/libGLESv2.so.2.0
b4353000 b43b5000 r-xp /usr/lib/libpixman-1.so.0.28.2
b43ca000 b43e2000 r-xp /usr/lib/libmount.so.1.1.0
b43f4000 b4408000 r-xp /usr/lib/libxcb.so.1.1.0
b4418000 b441f000 r-xp /lib/libcrypt-2.20-2014.11.so
b4457000 b4459000 r-xp /usr/lib/libiri.so
b4469000 b4474000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4485000 b44bb000 r-xp /usr/lib/libpulse.so.0.16.2
b44cc000 b450f000 r-xp /usr/lib/libsndfile.so.1.0.25
b4524000 b4539000 r-xp /lib/libexpat.so.1.5.2
b454b000 b4609000 r-xp /usr/lib/libcairo.so.2.11200.14
b461d000 b4625000 r-xp /usr/lib/libdrm.so.2.4.0
b4635000 b4638000 r-xp /usr/lib/libdri2.so.0.0.0
b4648000 b4696000 r-xp /usr/lib/libssl.so.1.0.0
b46ab000 b46b7000 r-xp /usr/lib/libeeze.so.1.13.0
b46c8000 b46d1000 r-xp /usr/lib/libethumb.so.1.13.0
b46e1000 b46e4000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46f4000 b48ab000 r-xp /usr/lib/libcrypto.so.1.0.0
b5696000 b569f000 r-xp /usr/lib/libXi.so.6.1.0
b56af000 b56b1000 r-xp /usr/lib/libXgesture.so.7.0.0
b56c1000 b56c5000 r-xp /usr/lib/libXtst.so.6.1.0
b56d5000 b56db000 r-xp /usr/lib/libXrender.so.1.3.0
b56eb000 b56f1000 r-xp /usr/lib/libXrandr.so.2.2.0
b5701000 b5703000 r-xp /usr/lib/libXinerama.so.1.0.0
b5714000 b5717000 r-xp /usr/lib/libXfixes.so.3.1.0
b5727000 b5732000 r-xp /usr/lib/libXext.so.6.4.0
b5742000 b5744000 r-xp /usr/lib/libXdamage.so.1.1.0
b5754000 b5756000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5766000 b5848000 r-xp /usr/lib/libX11.so.6.3.0
b585c000 b5863000 r-xp /usr/lib/libXcursor.so.1.0.2
b5873000 b588b000 r-xp /usr/lib/libudev.so.1.6.0
b588d000 b5890000 r-xp /lib/libattr.so.1.1.0
b58a0000 b58c0000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58c1000 b58c6000 r-xp /usr/lib/libffi.so.6.0.2
b58d7000 b58ef000 r-xp /lib/libz.so.1.2.8
b58ff000 b5901000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5911000 b59e6000 r-xp /usr/lib/libxml2.so.2.9.2
b59fb000 b5a96000 r-xp /usr/lib/libstdc++.so.6.0.20
b5ab2000 b5ab5000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5ac5000 b5ade000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5aef000 b5b00000 r-xp /lib/libresolv-2.20-2014.11.so
b5b14000 b5b8e000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5ba3000 b5ba5000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bb5000 b5bbc000 r-xp /usr/lib/libembryo.so.1.13.0
b5bcc000 b5bd6000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5be7000 b5bff000 r-xp /usr/lib/libpng12.so.0.50.0
b5c10000 b5c33000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c54000 b5c68000 r-xp /usr/lib/libector.so.1.13.0
b5c79000 b5c91000 r-xp /usr/lib/liblua-5.1.so
b5ca2000 b5cf9000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d0d000 b5d35000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d46000 b5d59000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d6a000 b5da4000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5db5000 b5dc3000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5dd3000 b5ddb000 r-xp /usr/lib/libtbm.so.1.0.0
b5deb000 b5df8000 r-xp /usr/lib/libeio.so.1.13.0
b5e08000 b5e0a000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e1a000 b5e1f000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e2f000 b5e46000 r-xp /usr/lib/libefreet.so.1.13.0
b5e58000 b5e78000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e88000 b5ea8000 r-xp /usr/lib/libecore_con.so.1.13.0
b5eaa000 b5eb0000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5ec0000 b5ed1000 r-xp /usr/lib/libemotion.so.1.13.0
b5ee2000 b5ee9000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ef9000 b5f08000 r-xp /usr/lib/libeo.so.1.13.0
b5f19000 b5f2b000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f3c000 b5f41000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f51000 b5f6a000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f7a000 b5f97000 r-xp /usr/lib/libeet.so.1.13.0
b5fb0000 b5ff8000 r-xp /usr/lib/libeina.so.1.13.0
b6009000 b6019000 r-xp /usr/lib/libefl.so.1.13.0
b602a000 b610f000 r-xp /usr/lib/libicuuc.so.51.1
b612c000 b626c000 r-xp /usr/lib/libicui18n.so.51.1
b6283000 b62bb000 r-xp /usr/lib/libecore_x.so.1.13.0
b62cd000 b62d0000 r-xp /lib/libcap.so.2.21
b62e0000 b6309000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b631a000 b6321000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6333000 b636a000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b637b000 b6466000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6479000 b64f2000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6504000 b6509000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6519000 b6523000 r-xp /usr/lib/libvconf.so.0.2.45
b6533000 b6535000 r-xp /usr/lib/libvasum.so.0.3.1
b6545000 b6547000 r-xp /usr/lib/libttrace.so.1.1
b6557000 b655a000 r-xp /usr/lib/libiniparser.so.0
b656a000 b6590000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65a0000 b65a5000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65b6000 b65cd000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65de000 b6649000 r-xp /lib/libm-2.20-2014.11.so
b665a000 b6660000 r-xp /lib/librt-2.20-2014.11.so
b6671000 b667e000 r-xp /usr/lib/libunwind.so.8.0.1
b66b4000 b67d8000 r-xp /lib/libc-2.20-2014.11.so
b67ed000 b6806000 r-xp /lib/libgcc_s-4.9.so.1
b6816000 b68f8000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6909000 b6933000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6944000 b6980000 r-xp /usr/lib/libsystemd.so.0.4.0
b6982000 b6a05000 r-xp /usr/lib/libedje.so.1.13.0
b6a18000 b6a36000 r-xp /usr/lib/libecore.so.1.13.0
b6a56000 b6bdd000 r-xp /usr/lib/libevas.so.1.13.0
b6c12000 b6c26000 r-xp /lib/libpthread-2.20-2014.11.so
b6c3a000 b6e6e000 r-xp /usr/lib/libelementary.so.1.13.0
b6e9d000 b6ea1000 r-xp /usr/lib/libsmack.so.1.0.0
b6eb1000 b6eb8000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6ec8000 b6eca000 r-xp /usr/lib/libdlog.so.0.0.0
b6eda000 b6edd000 r-xp /usr/lib/libbundle.so.0.1.22
b6eed000 b6eef000 r-xp /lib/libdl-2.20-2014.11.so
b6f00000 b6f18000 r-xp /usr/lib/libaul.so.0.1.0
b6f2c000 b6f31000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f42000 b6f4f000 r-xp /usr/lib/liblptcp.so
b6f61000 b6f65000 r-xp /usr/lib/libsys-assert.so
b6f76000 b6f96000 r-xp /lib/ld-2.20-2014.11.so
b6fa7000 b6fac000 r-xp /usr/bin/launchpad-loader
b7b86000 b7e3f000 rw-p [heap]
be992000 be9b3000 rw-p [stack]
End of Maps Information

Callstack Information (PID:8756)
Call Stack Count: 18
 0: setting_view_cb + 0x29 (0xb2821e8a) [/opt/usr/apps/org.example.example/bin/example] + 0x5e8a
 1: (0xb6a8b175) [/usr/lib/libevas.so.1] + 0x35175
 2: (0xb5f04219) [/usr/lib/libeo.so.1] + 0xb219
 3: eo_event_callback_call + 0x68 (0xb5f02fb9) [/usr/lib/libeo.so.1] + 0x9fb9
 4: (0xb6a8b515) [/usr/lib/libevas.so.1] + 0x35515
 5: (0xb6a93725) [/usr/lib/libevas.so.1] + 0x3d725
 6: evas_canvas_event_feed_mouse_down + 0x6a (0xb6a98f6b) [/usr/lib/libevas.so.1] + 0x42f6b
 7: evas_event_feed_mouse_down + 0x30 (0xb6a9c939) [/usr/lib/libevas.so.1] + 0x46939
 8: (0xb46e3173) [/usr/lib/libecore_input_evas.so.1] + 0x2173
 9: (0xb6a23c4b) [/usr/lib/libecore.so.1] + 0xbc4b
10: (0xb6a29a5d) [/usr/lib/libecore.so.1] + 0x11a5d
11: ecore_main_loop_begin + 0x3e (0xb6a29c83) [/usr/lib/libecore.so.1] + 0x11c83
12: appcore_efl_main + 0x20c (0xb6f2f2bd) [/usr/lib/libappcore-efl.so.1] + 0x32bd
13: ui_app_main + 0xc0 (0xb3fe5909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
14: main + 0x10e (0xb2821677) [/opt/usr/apps/org.example.example/bin/example] + 0x5677
15: (0xb6fa8bb5) [/opt/usr/apps/org.example.example/bin/example] + 0x1bb5
16: __libc_start_main + 0x114 (0xb66ca4bc) [/lib/libc.so.6] + 0x164bc
17: (0xb6fa8eb4) [/opt/usr/apps/org.example.example/bin/example] + 0x1eb4
End of Call Stack

Package Information
Package Name: org.example.example
Package ID : org.example.example
Version: 1.0.0
Package Type: tpk
App Name: forpet
App ID: org.example.example
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
CAM_APP (27314): CamControl.cpp: stopPreview(324) > [0;35mCamState is [1][0;m
06-03 01:31:26.790+0900 W/CAM_APP (27314): CamDevControl.cpp: stopPreview(192) > [0;35mBEGIN[0;m
06-03 01:31:26.800+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 12
06-03 01:31:26.810+0900 W/AUL     (27314): launch.c: app_request_to_launchpad(396) > request cmd(4) to(15849)
06-03 01:31:26.810+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 4
06-03 01:31:26.820+0900 E/AUL_AMD (  610): amd_request.c: __request_handler(1139) > terminate request has been denied by smack
06-03 01:31:26.830+0900 W/AUL     (27314): launch.c: app_request_to_launchpad(425) > request cmd(4) result(-8)
06-03 01:31:26.830+0900 E/CAPI_APPFW_APP_MANAGER(27314): app_manager.c: app_manager_terminate_app(298) > [app_manager_terminate_app] APP_MANAGER_ERROR_PERMISSION_DENIED(0xfffffff3) : Permission denied
06-03 01:31:26.830+0900 E/CAM_APP (27314): CamLauncher.cpp: terminatePreloadImageViewer(257) > [0;31m* Critical * app_manager_terminate_app failed - [-13][0;m
06-03 01:31:26.830+0900 W/CAM_APP (27314): CamLauncher.cpp: terminatePreloadImageViewer(268) > [0;35mEND[0;m
06-03 01:31:26.830+0900 W/CAM_APP (27314): CamControl.cpp: __pause(1360) > [0;35mEND[0;m
06-03 01:31:26.830+0900 W/CAM_APP (27314): CamStandbyView.cpp: operator()(267) > [0;35mevent type: 2[0;m
06-03 01:31:26.830+0900 E/CAM_APP (27314): CamStandbyView.cpp: __destroyQuickSetting(1542) > [0;31m* Critical * __quickSetting is nullptr[0;m
06-03 01:31:26.830+0900 W/CAM_APP (27314): CamView.cpp: stopSelfTerminateTimer(356) > [0;35mHIT[0;m
06-03 01:31:26.830+0900 W/CAM_APP (27314): CamStandbyView.cpp: __stopCountDownTimer(2561) > [0;35mBEGIN[0;m
06-03 01:31:26.830+0900 I/ISP_AE  (27314): AE_TEST:----cur_index:236, cur_lum:58, next_index:237, target_lum:62
06-03 01:31:26.830+0900 W/CAM_APP (27314): CamSoundSessionMgr.cpp: unsetCaptureMode(125) > [0;35mBEGIN[0;m
06-03 01:31:26.830+0900 W/CAM_APP (27314): CamSoundSessionMgr.cpp: unsetCaptureMode(141) > [0;35mdonot need to unset capture mode[0;m
06-03 01:31:26.830+0900 W/CAM_APP (27314): CamSoundSessionMgr.cpp: unsetCaptureMode(144) > [0;35mEND[0;m
06-03 01:31:26.830+0900 W/CAM_APP (27314): CamStandbyView.cpp: __stopCountDownTimer(2580) > [0;35mEND[0;m
06-03 01:31:26.830+0900 W/CAM_APP (27314): CamStandbyView.cpp: __destroyModeTextDestroyTimer(2387) > [0;35mmode text destroy timer is destroyed[0;m
06-03 01:31:26.830+0900 D/alPrinter0(27314): [CALL][0x9c26e260][0]AlAwbInterfaceSendCommand :mode=0 ins=0x00000000
06-03 01:31:26.830+0900 D/alPrinter0(27314): [CMD0][if=9c26e260,Wrap=9c273790]ID=3502 : 00,00,00,00,00,00,00,00
06-03 01:31:26.830+0900 D/awb_al_cmd0(27314): [alAisCmd_SetColorMode2] muiMd=0 muiAct:0  
06-03 01:31:26.830+0900 D/alPrinter0(27314): [CALL][0x9c26e260][0]AlAwbInterfaceSendCommand :mode=0 ins=0x00000000
06-03 01:31:26.830+0900 D/alPrinter0(27314): [CMD0][if=9c26e260,Wrap=9c273790]ID=1503 : 00,00,00,00,00,00,00,00
06-03 01:31:26.840+0900 D/awb_al_cmd0(27314): [alAisCmd_SetColorLock] muiAwblc:0 
06-03 01:31:26.840+0900 D/alPrinter0(27314): [CALL][0x9c26e260][0]AlAwbInterfaceMain :mode=0 ins=0x65746e69
06-03 01:31:26.840+0900 D/alPrinter0(27314): [AIS_WRAP]msiFlash_state=0
06-03 01:31:26.840+0900 D/alPrinter0(27314): [LOCK]0
06-03 01:31:26.840+0900 D/alPrinter0(27314): [SuperHighCTemp] Mapin:  1.00, detect:   0.35,   0.38 CTemp:4755.3
06-03 01:31:26.840+0900 D/alPrinter0(27314): [HSC]Mix=00013333,Csd=000115e2 ,(BV= 3.467,x=0.350,y=0.374)
06-03 01:31:26.840+0900 D/alPrinter0(27314): [AlHscWrap_Main]:4, 0x00013333,0x00013333
06-03 01:31:26.840+0900 D/alPrinter0(27314): [AIS_WRAP]In BV=3.395301 ,Awb Bv=3.466736 in/out_0
06-03 01:31:26.840+0900 D/alPrinter0(27314): [AIS_WRAP]RGain=1.327652,GGain=1.000000,BGain=1.497177,Dtct=0.349640,0.373535 ,Curr=0.348709,0.372116 ,CTmep: QC=5386, AL= 5074
06-03 01:31:26.840+0900 W/CAM_APP (27314): CamSystemDeviceMgr.cpp: setMdnieMode(439) > [0;35mBEGIN[0;m
06-03 01:31:26.840+0900 W/CAM_APP (27314): CamSystemDeviceMgr.cpp: __invokeDbusMethodSync(714) > [0;35mBEGIN[0;m
06-03 01:31:26.850+0900 W/CAM_APP (27314): CamSystemDeviceMgr.cpp: __invokeDbusMethodSync(756) > [0;35mEND[0;m
06-03 01:31:26.850+0900 W/CAM_APP (27314): CamSystemDeviceMgr.cpp: __setEnhanceScenario(476) > [0;35mset mdnie - SCENARIO_UI [0;m
06-03 01:31:26.850+0900 W/CAM_APP (27314): CamSystemDeviceMgr.cpp: __invokeDbusMethodSync(714) > [0;35mBEGIN[0;m
06-03 01:31:26.850+0900 W/CAM_APP (27314): CamSystemDeviceMgr.cpp: __invokeDbusMethodSync(756) > [0;35mEND[0;m
06-03 01:31:26.850+0900 W/CAM_APP (27314): CamSystemDeviceMgr.cpp: setMdnieMode(443) > [0;35mEND[0;m
06-03 01:31:26.860+0900 W/CAM_APP (27314): CamCoordRotationMgr.cpp: stop(83) > [0;35mBEGIN[0;m
06-03 01:31:26.870+0900 W/CAM_APP (27314): CamCoordRotationMgr.cpp: stop(97) > [0;35mEND[0;m
06-03 01:31:26.870+0900 W/CAM_APP (27314): CamApp.cpp: onPause(80) > [0;35mEND[0;m
06-03 01:31:26.930+0900 I/ISP_AE  (27314): AE_TEST:----cur_index:237, cur_lum:60, next_index:237, target_lum:62
06-03 01:31:26.930+0900 D/alPrinter0(27314): [CALL][0x9c26e260][0]AlAwbInterfaceSendCommand :mode=0 ins=0x00000000
06-03 01:31:26.930+0900 D/alPrinter0(27314): [CMD0][if=9c26e260,Wrap=9c273790]ID=3502 : 00,00,00,00,00,00,00,00
06-03 01:31:26.930+0900 D/awb_al_cmd0(27314): [alAisCmd_SetColorMode2] muiMd=0 muiAct:0  
06-03 01:31:26.930+0900 D/alPrinter0(27314): [CALL][0x9c26e260][0]AlAwbInterfaceSendCommand :mode=0 ins=0x00000000
06-03 01:31:26.930+0900 D/alPrinter0(27314): [CMD0][if=9c26e260,Wrap=9c273790]ID=1503 : 00,00,00,00,00,00,00,00
06-03 01:31:26.930+0900 D/awb_al_cmd0(27314): [alAisCmd_SetColorLock] muiAwblc:0 
06-03 01:31:26.930+0900 D/alPrinter0(27314): [CALL][0x9c26e260][0]AlAwbInterfaceMain :mode=0 ins=0x65746e69
06-03 01:31:26.930+0900 D/alPrinter0(27314): [AIS_WRAP]msiFlash_state=0
06-03 01:31:26.930+0900 D/alPrinter0(27314): [LOCK]0
06-03 01:31:26.930+0900 D/alPrinter0(27314): [SuperHighCTemp] Mapin:  1.00, detect:   0.35,   0.38 CTemp:4765.0
06-03 01:31:26.930+0900 D/alPrinter0(27314): [HSC]Mix=00013333,Csd=00010b56 ,(BV= 3.463,x=0.349,y=0.373)
06-03 01:31:26.930+0900 D/alPrinter0(27314): [AlHscWrap_Main]:3, 0x00013333,0x00013333
06-03 01:31:26.930+0900 D/alPrinter0(27314): [AIS_WRAP]In BV=3.395301 ,Awb Bv=3.463196 in/out_0
06-03 01:31:26.930+0900 D/alPrinter0(27314): [AIS_WRAP]RGain=1.327133,GGain=1.000000,BGain=1.499649,Dtct=0.349365,0.373260 ,Curr=0.348953,0.372314 ,CTmep: QC=5373, AL= 5063
06-03 01:31:26.950+0900 E/TIZEN_N_EFL_UTIL_WINDOW(27314): efl_util_window_dump.c: _efl_util_capture_window_get_window_buffer(526) > 
06-03 01:31:26.950+0900 E/TIZEN_N_EFL_UTIL_WINDOW(27314):  video buffer captured successfully
06-03 01:31:26.960+0900 I/ISP_AE  (27314): calc_iso=70,real_gain=23,iso=0
06-03 01:31:26.980+0900 I/TIZEN_N_EFL_UTIL_WINDOW(27314): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 107
06-03 01:31:26.980+0900 E/APP_CORE(27314): appcore-efl.c: _capture_and_make_file(1619) > win[a800003] widget[720] height[1280]
06-03 01:31:26.980+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 33
06-03 01:31:26.990+0900 E/RESOURCED(  653): nfacct-rule.c: generate_counter_name(790) > Can't get interface name for counter , iftype 0)!
06-03 01:31:26.990+0900 E/RESOURCED(  653): nfacct-rule.c: generate_counter_name(790) > Can't get interface name for counter , iftype 0)!
06-03 01:31:27.040+0900 E/MEDIA_SERVER_THUMB(  883): media-server-thumb.c: ms_camera_vconf_cb(110) > Camera is stopping
06-03 01:31:27.040+0900 E/MEDIA_SERVER_THUMB(  883): media-server-thumb.c: ms_camera_vconf_cb(116) > [no-err] g_thumb_server_extracting = 1 -> FALSE
06-03 01:31:27.080+0900 W/MEDIA_THUMBNAIL_SERVER( 9085): thumb-server-internal.c: _thumb_daemon_camera_vconf_cb(202) > [32mcamera state: 1 / g_source_id: 0
06-03 01:31:27.260+0900 W/CAM_APP (27314): CamDevControl.cpp: __stateChangeCb(1225) > [0;35mBEGIN[0;m
06-03 01:31:27.260+0900 W/CAM_APP (27314): CamControl.cpp: operator()(375) > [0;35mstate changed - previous [2], current [1][0;m
06-03 01:31:27.270+0900 W/CAM_APP (27314): CamDevControl.cpp: __stateChangeCb(1233) > [0;35mEND[0;m
06-03 01:31:27.630+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 01:31:27.640+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 01:31:27.640+0900 W/CAM_APP (27314): CamDevControl.cpp: stopPreview(213) > [0;35mEND[0;m
06-03 01:31:27.640+0900 W/CAM_APP (27314): CamControl.cpp: stopPreview(335) > [0;35mEND[0;m
06-03 01:31:27.640+0900 W/CAM_APP (27314): CamSubControlMgr.cpp: __threadCb(351) > [0;35mdone[0;m
06-03 01:31:27.640+0900 W/MEDIA_THUMBNAIL_SERVER( 9085): thumb-server-internal.c: _thumb_daemon_camera_vconf_cb(202) > [32mcamera state: 0 / g_source_id: 0
06-03 01:31:27.640+0900 W/CAM_APP (27314): CamSoundSessionMgr.cpp: setOption(82) > [0;35mBEGIN[0;m
06-03 01:31:27.640+0900 I/TIZEN_N_SOUND_MANAGER(27314): sound_manager_product.c: sound_manager_multi_session_set_option(886) > return : session=0xaee19998, type=3
06-03 01:31:27.640+0900 W/CAM_APP (27314): CamSoundSessionMgr.cpp: setOption(95) > [0;35mEND[0;m
06-03 01:31:27.640+0900 W/CAM_APP (27314): CamSoundSessionMgr.cpp: setOption(82) > [0;35mBEGIN[0;m
06-03 01:31:27.640+0900 I/TIZEN_N_SOUND_MANAGER(27314): sound_manager_product.c: sound_manager_multi_session_set_option(886) > return : session=0xaee19998, type=0
06-03 01:31:27.640+0900 W/CAM_APP (27314): CamSoundSessionMgr.cpp: setOption(95) > [0;35mEND[0;m
06-03 01:31:27.650+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 01:31:27.650+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 01:31:27.670+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 01:31:27.680+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 01:31:27.690+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 01:31:27.690+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 01:31:27.710+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 01:31:27.710+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 01:31:27.730+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 01:31:27.730+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 01:31:27.740+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 01:31:27.750+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 01:31:27.760+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 01:31:27.770+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 01:31:27.780+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 01:31:27.791+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 01:31:27.791+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 01:31:27.791+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 01:31:27.801+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 01:31:27.811+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 01:31:27.821+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 01:31:27.821+0900 W/IV-MAIN  (15849): [15849] 27:25:59.902[F:ivug-main-view.c L: 4380][00][HIGH] Hide Menu. bShowMenu=1
06-03 01:31:27.821+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 01:31:27.821+0900 W/IV-MAIN  (15849): [15849] 27:25:59.902[F:ivug-main-view.c L: 4287][00][HIGH] Remove Hide Timer. ivug_main_view_hide_menu_bar(4388)
06-03 01:31:27.841+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[2]
06-03 01:31:27.841+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 01:31:29.082+0900 E/PKGMGR  ( 9138): pkgmgr.c: pkgmgr_client_uninstall(2142) > uninstall pkg start.
06-03 01:31:29.192+0900 E/PKGMGR_SERVER( 9140): pkgmgr-server.c: main(2414) > package manager server start
06-03 01:31:29.252+0900 E/PKGMGR_SERVER( 9140): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
06-03 01:31:29.252+0900 E/PKGMGR_SERVER( 9140): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [org.example.example]
06-03 01:31:29.262+0900 E/PKGMGR  ( 9138): pkgmgr.c: pkgmgr_client_uninstall(2270) > uninstall pkg finish, ret=[91380002]
06-03 01:31:29.452+0900 E/rpm-installer( 9143): rpm-cmdline.c: __ri_is_core_tpk_app(302) > This is a core tpk app.
06-03 01:31:29.502+0900 I/Tizen::App( 1210): (1894) > PackageEventHandler - req: 12100002, pkg_type: tpk, pkg_name: org.example.example, key: start, val: uninstall
06-03 01:31:29.502+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
06-03 01:31:29.512+0900 I/SYNCSERVICE(  945): SyncManager_SyncManager.cpp: OnPackageUninstalled(403) > OnPackageUninstalled [type tpk] type [pkdId:org.example.example]
06-03 01:31:29.512+0900 W/AUL_AMD (  610): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
06-03 01:31:29.522+0900 I/Tizen::App( 1210): (1584) > Package = [org.example.example], Key = [start], Value = [uninstall], install = [1]
06-03 01:31:29.522+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:31:29.522+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:31:29.522+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:31:29.522+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:31:29.522+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
06-03 01:31:29.532+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
06-03 01:31:29.532+0900 E/rpm-installer( 9143): rpm-installer.c: __ri_check_running_app(2267) > app[org.example.example] , running state[0].
06-03 01:31:29.542+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.example]
06-03 01:31:29.542+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.example]
06-03 01:31:29.542+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
06-03 01:31:29.582+0900 I/SYNCSERVICE(  945): SyncManager_SyncManager.cpp: OnPackageUninstalled(403) > OnPackageUninstalled [type tpk] type [pkdId:org.example.example]
06-03 01:31:29.592+0900 E/RESOURCED(  653): nfacct-rule.c: generate_counter_name(790) > Can't get interface name for counter , iftype 0)!
06-03 01:31:29.592+0900 E/RESOURCED(  653): nfacct-rule.c: generate_counter_name(790) > Can't get interface name for counter , iftype 0)!
06-03 01:31:29.652+0900 E/PKGMGR_PARSER( 9143): pkgmgr_parser.c: __check_theme(154) > theme for uninstallation.
06-03 01:31:29.672+0900 I/PRIVACY-MANAGER-CLIENT( 9143): SocketClient.cpp: SocketClient(37) > Client created
06-03 01:31:29.672+0900 I/PRIVACY-MANAGER-CLIENT( 9143): SocketClient.cpp: connect(62) > Client connected
06-03 01:31:29.672+0900 I/PRIVACY-MANAGER-SERVER(  906): SocketService.cpp: mainloop(230) > Got incoming connection
06-03 01:31:29.682+0900 I/PRIVACY-MANAGER-CLIENT( 9143): SocketClient.cpp: disconnect(72) > Client disconnected
06-03 01:31:29.692+0900 E/PKGMGR_CERT( 9143): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
06-03 01:31:29.692+0900 E/PKGMGR_CERT( 9143): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
06-03 01:31:29.702+0900 E/PKGMGR_CERT( 9143): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
06-03 01:31:29.802+0900 E/PKGMGR_CERT( 9143): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
06-03 01:31:29.802+0900 E/PKGMGR_CERT( 9143): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
06-03 01:31:29.802+0900 E/PKGMGR_CERT( 9143): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
06-03 01:31:29.802+0900 E/rpm-installer( 9143): rpm-installer.c: _rpm_uninstall_pkg_with_dbpath(3415) > success
06-03 01:31:29.802+0900 E/rpm-installer( 9143): rpm-installer.c: _rpm_uninstall_pkg_with_dbpath(3416) > try to classify and delete residual files
06-03 01:31:31.004+0900 E/PKGMGR_SERVER( 9140): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
06-03 01:31:31.004+0900 W/MEDIA_THUMBNAIL_SERVER( 9085): thumb-server-internal.c: _thumb_server_read_socket(514) > [32mreceived KILL msg from thumbnail agent.
06-03 01:31:31.004+0900 W/MEDIA_THUMBNAIL_SERVER( 9085): thumb-server-internal.c: _thumb_server_read_socket(575) > [32mShutting down...
06-03 01:31:31.004+0900 E/MEDIA_THUMBNAIL_DCM( 9085): thumb-server-dcm.c: _thumb_server_dcm_quit_main_loop(445) > [31mInvalid DCM thread main loop![0m
06-03 01:31:31.144+0900 E/MEDIA_SERVER(  883): media-server-main.c: _ms_signal_handler(183) > [9085] Thumbnail server is stopped by media-server
06-03 01:31:31.144+0900 E/MEDIA_SERVER_THUMB(  883): media-server-thumb.c: ms_thumb_reset_server_status(162) > [no-err] g_thumb_server_extracting = 0 -> FALSE
06-03 01:31:31.504+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 8564 pgid = 8564
06-03 01:31:31.504+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(143) > dead_pid(8564)
06-03 01:31:31.524+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-03 01:31:31.524+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-03 01:31:31.524+0900 E/AUL_PAD ( 1359): launchpad.c: main(698) > error reading sigchld info
06-03 01:31:31.524+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 8564
06-03 01:31:31.524+0900 I/Tizen::App( 1210): (243) > App[org.tizen.crash-viewer] pid[8564] terminate event is forwarded
06-03 01:31:31.524+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 01:31:31.524+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [org.tizen.crash-viewer, 8564, ]
06-03 01:31:31.524+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 01:31:31.524+0900 I/Tizen::App( 1210): (506) > TerminatedApp(org.tizen.crash-viewer)
06-03 01:31:31.524+0900 I/Tizen::App( 1210): (512) > Not registered pid(8564)
06-03 01:31:31.524+0900 I/Tizen::System( 1210): (246) > Terminated app [org.tizen.crash-viewer]
06-03 01:31:31.524+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 01:31:31.524+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 8564
06-03 01:31:31.524+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 8564
06-03 01:31:31.524+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3371
06-03 01:31:31.534+0900 E/RESOURCED(  653): datausage-common.c: app_terminated_cb(646) > No classid to terminate!
06-03 01:31:31.534+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 01:31:31.534+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for org.tizen.crash-viewer, 8564.
06-03 01:31:31.884+0900 I/APP_CORE(27314): appcore-efl.c: __do_app(514) > [APP 27314] Event: MEM_FLUSH State: PAUSED
06-03 01:31:32.175+0900 I/Tizen::App( 1210): (1894) > PackageEventHandler - req: 12100002, pkg_type: tpk, pkg_name: org.example.example, key: end, val: ok
06-03 01:31:32.175+0900 I/Tizen::App( 1210): (83) > Uninstallation is Completed. [Package = org.example.example]
06-03 01:31:32.185+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
06-03 01:31:32.185+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
06-03 01:31:32.185+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
06-03 01:31:32.185+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.example]
06-03 01:31:32.185+0900 I/SYNCSERVICE(  945): SyncManager_SyncManager.cpp: OnPackageUninstalled(403) > OnPackageUninstalled [type tpk] type [pkdId:org.example.example]
06-03 01:31:32.185+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:31:32.185+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:31:32.185+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:31:32.185+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:31:32.185+0900 W/AUL_AMD (  610): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1104) > g_hash_table_foreach_remove, 1
06-03 01:31:32.195+0900 I/Tizen::App( 1210): (709) > Enter. package(org.example.example), uninstallationResult(1)
06-03 01:31:32.195+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _DoPkgJob(494) >  #8
06-03 01:31:32.195+0900 E/PUSHD   ( 1001): db.c: _get_app_info_by_query(361) > DB step: 101 [unknown error]
06-03 01:31:32.195+0900 E/PUSHD   ( 1001): db.c: db_reg_get_by_tizen_pkg_id(438) > Fail to get app_info
06-03 01:31:32.215+0900 I/SYNCSERVICE(  945): SyncManager_SyncAdapterAggregator.cpp: HandlePackageUninstalled(129) > Removing sync adapter for package [org.example.example]
06-03 01:31:32.215+0900 I/SYNCSERVICE(  945): SyncManager_SyncJobsAggregator.cpp: HandlePackageUninstalled(197) > Sync jobs for package org.example.example are not found
06-03 01:31:32.215+0900 E/PKGMGR_SERVER( 9140): pkgmgr-server.c: sighandler(417) > child NORMAL exit [9143]
06-03 01:31:32.225+0900 E/Tizen::App( 1210): (1141) > [E_PKG_NOT_INSTALLED] pkgmgrinfo_pkginfo_get_pkginfo() is failed. result=[-1], package=[org.example.example]
06-03 01:31:32.225+0900 E/Tizen::App( 1210): (278) > [E_PKG_NOT_INSTALLED] package (org.example.example) is not found.
06-03 01:31:32.225+0900 E/Tizen::App( 1210): (2193) > GetPackageInfoN(org.example.example) failed.
06-03 01:31:32.235+0900 I/Tizen::App( 1210): (720) > Exit.
06-03 01:31:32.235+0900 I/Tizen::App( 1210): (840) > Enter.
06-03 01:31:32.235+0900 I/Tizen::App( 1210): (1584) > Package = [org.example.example], Key = [end], Value = [ok], install = [96]
06-03 01:31:32.235+0900 I/Tizen::App( 1210): (883) > Exit.
06-03 01:31:32.275+0900 E/PKGMGR_INFO(  860): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_filter_foreach_pkginfo(2152) > where = package_info.package_support_disable IN ('true','True') and package_info.package_nodisplay IN ('false','False') and package_info.package_disable IN ('true','True')
06-03 01:31:32.275+0900 E/PKGMGR_INFO(  860): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_filter_foreach_pkginfo(2158) > query = select * from package_info LEFT OUTER JOIN package_localized_info ON package_info.package=package_localized_info.package and package_localized_info.package_locale IN ('No Locale', 'ko-kr') where package_info.package_support_disable IN ('true','True') and package_info.package_nodisplay IN ('false','False') and package_info.package_disable IN ('true','True')
06-03 01:31:32.395+0900 E/PKGMGR  ( 9150): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
06-03 01:31:32.435+0900 E/PKGMGR_SERVER( 9140): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.example-1.0.0-arm.tpk]
06-03 01:31:32.445+0900 E/PKGMGR_INFO( 9140): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.example-1.0.0-arm.tpk] not found in DB
06-03 01:31:32.455+0900 E/rpm-installer( 9140): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
06-03 01:31:32.465+0900 E/PKGMGR_SERVER( 9140): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
06-03 01:31:32.465+0900 E/PKGMGR  ( 9150): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[91500002]
06-03 01:31:32.605+0900 E/PKGMGR_INSTALLER( 9152): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
06-03 01:31:32.605+0900 E/rpm-installer( 9152): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.example-1.0.0-arm.tpk] is tpk package.
06-03 01:31:32.625+0900 E/rpm-installer( 9152): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
06-03 01:31:32.625+0900 E/rpm-installer( 9152): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
06-03 01:31:32.625+0900 E/rpm-installer( 9152): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
06-03 01:31:32.635+0900 E/rpm-installer( 9152): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
06-03 01:31:32.635+0900 E/rpm-installer( 9152): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
06-03 01:31:32.725+0900 W/CERT_SVC_VCORE( 9152): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
06-03 01:31:32.795+0900 I/Tizen::App( 1210): (1894) > PackageEventHandler - req: 12100002, pkg_type: tpk, pkg_name: org.example.example, key: start, val: install
06-03 01:31:32.795+0900 I/Tizen::App( 1210): (1584) > Package = [org.example.example], Key = [start], Value = [install], install = [96]
06-03 01:31:32.795+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:31:32.795+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:31:32.795+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:31:32.795+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:31:32.805+0900 I/Tizen::App( 1210): (1894) > PackageEventHandler - req: 12100002, pkg_type: tpk, pkg_name: org.example.example, key: install_percent, val: 30
06-03 01:31:32.805+0900 I/Tizen::App( 1210): (119) > InstallationInProgress [30]
06-03 01:31:32.805+0900 I/Tizen::App( 1210): (1584) > Package = [org.example.example], Key = [install_percent], Value = [30], install = [96]
06-03 01:31:32.805+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:31:32.805+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:31:32.805+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:31:32.805+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:31:32.986+0900 I/Tizen::Net::Wifi( 1210): (941) > The background scan result updated.
06-03 01:31:33.006+0900 E/PKGMGR_SERVER( 9140): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
06-03 01:31:33.026+0900 E/rpm-installer( 9152): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
06-03 01:31:33.026+0900 E/rpm-installer( 9152): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
06-03 01:31:33.026+0900 E/rpm-installer( 9152): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
06-03 01:31:33.026+0900 E/rpm-installer( 9152): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
06-03 01:31:33.026+0900 E/rpm-installer( 9152): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
06-03 01:31:33.026+0900 E/rpm-installer( 9152): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
06-03 01:31:33.036+0900 E/PKGMGR_PARSER( 9152): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
06-03 01:31:33.046+0900 E/PKGMGR_PARSER( 9152): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
06-03 01:31:33.086+0900 I/PRIVACY-MANAGER-CLIENT( 9152): SocketClient.cpp: SocketClient(37) > Client created
06-03 01:31:33.336+0900 E/PKGMGR_PARSER( 9152): pkgmgr_parser.c: __check_theme(142) > theme for installation.
06-03 01:31:33.356+0900 E/PKGMGR_CERT( 9152): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
06-03 01:31:33.356+0900 E/PKGMGR_CERT( 9152): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 107
06-03 01:31:33.356+0900 E/PKGMGR_CERT( 9152): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 107
06-03 01:31:33.356+0900 E/PKGMGR_CERT( 9152): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 44 2
06-03 01:31:33.356+0900 E/PKGMGR_CERT( 9152): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 45 2
06-03 01:31:33.366+0900 E/PKGMGR_CERT( 9152): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 46 2
06-03 01:31:33.366+0900 E/PKGMGR_CERT( 9152): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 47 2
06-03 01:31:33.366+0900 E/PKGMGR_CERT( 9152): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
06-03 01:31:33.376+0900 E/rpm-installer( 9152): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1956) > skip! empty dirpath=[/opt/usr/apps/org.example.example/lib]
06-03 01:31:33.376+0900 I/Tizen::App( 1210): (1894) > PackageEventHandler - req: 12100002, pkg_type: tpk, pkg_name: org.example.example, key: install_percent, val: 60
06-03 01:31:33.376+0900 I/Tizen::App( 1210): (119) > InstallationInProgress [60]
06-03 01:31:33.376+0900 I/Tizen::App( 1210): (1584) > Package = [org.example.example], Key = [install_percent], Value = [60], install = [96]
06-03 01:31:33.376+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:31:33.376+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:31:33.376+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:31:33.376+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:31:33.396+0900 E/rpm-installer( 9152): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
06-03 01:31:33.426+0900 E/rpm-installer( 9152): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
06-03 01:31:33.426+0900 I/Tizen::App( 1210): (1894) > PackageEventHandler - req: 12100002, pkg_type: tpk, pkg_name: org.example.example, key: install_percent, val: 100
06-03 01:31:33.426+0900 I/Tizen::App( 1210): (119) > InstallationInProgress [100]
06-03 01:31:33.426+0900 I/Tizen::App( 1210): (1584) > Package = [org.example.example], Key = [install_percent], Value = [100], install = [96]
06-03 01:31:33.426+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:31:33.426+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:31:33.426+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:31:33.426+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:31:34.998+0900 E/PKGMGR_SERVER( 9140): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
06-03 01:31:35.268+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
06-03 01:31:35.268+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
06-03 01:31:35.268+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
06-03 01:31:35.268+0900 I/Tizen::App( 1210): (1894) > PackageEventHandler - req: 12100002, pkg_type: tpk, pkg_name: org.example.example, key: end, val: ok
06-03 01:31:35.268+0900 I/Tizen::App( 1210): (78) > Installation is Completed. [Package = org.example.example]
06-03 01:31:35.268+0900 I/Tizen::App( 1210): (671) > Enter. package(org.example.example), installationResult(0)
06-03 01:31:35.268+0900 I/Tizen::App( 1210): (1360) > package(org.example.example), version(1.0.0), type(tpk), displayName(forpet), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.example), storeClient(), appRootPath(/opt/usr/apps/org.example.example)
06-03 01:31:35.298+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.example]
06-03 01:31:35.298+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.example]
06-03 01:31:35.298+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
06-03 01:31:35.298+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
06-03 01:31:35.298+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.example]
06-03 01:31:35.298+0900 W/ISF_PANEL_EFL(  768): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
06-03 01:31:35.308+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:31:35.308+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:31:35.308+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:31:35.308+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:31:35.318+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[forpet] enable[1] system[0]
06-03 01:31:35.318+0900 E/HOME_APPS(  860): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.example] mdm is not enabled
06-03 01:31:35.318+0900 I/Tizen::App( 1210): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.example]
06-03 01:31:35.318+0900 E/cluster-home(  860): mainmenu-data-manager.cpp: GetBoxDataByAppId(2539) >  cannot find box with appid[org.example.example]
06-03 01:31:35.338+0900 I/Tizen::App( 1210): (416) > appName = [example]
06-03 01:31:35.338+0900 I/Tizen::App( 1210): (509) > exe = [/opt/usr/apps/org.example.example/bin/example], displayName = [forpet], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-03 01:31:35.338+0900 E/PKGMGR_INFO( 1210): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
06-03 01:31:35.338+0900 I/Tizen::App( 1210): (683) > Application count(1) in this package
06-03 01:31:35.338+0900 I/Tizen::App( 1210): (840) > Enter.
06-03 01:31:35.338+0900 I/Tizen::App( 1210): (703) > Exit.
06-03 01:31:35.338+0900 I/Tizen::App( 1210): (1584) > Package = [org.example.example], Key = [end], Value = [ok], install = [96]
06-03 01:31:35.348+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[forpet] enable[1] system[0]
06-03 01:31:35.358+0900 I/Tizen::App( 1210): (416) > appName = [example]
06-03 01:31:35.358+0900 I/Tizen::App( 1210): (509) > exe = [/opt/usr/apps/org.example.example/bin/example], displayName = [forpet], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-03 01:31:35.358+0900 I/Tizen::App( 1210): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.example.info]
06-03 01:31:35.358+0900 I/Tizen::App( 1210): (131) > Enter
06-03 01:31:35.368+0900 I/Tizen::App( 1210): (137) > org.example.example does not have launch condition
06-03 01:31:35.368+0900 I/Tizen::App( 1210): (883) > Exit.
06-03 01:31:35.378+0900 E/util-view(  860): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
06-03 01:31:35.398+0900 E/PKGMGR_SERVER( 9140): pkgmgr-server.c: sighandler(417) > child NORMAL exit [9152]
06-03 01:31:35.408+0900 E/util-view(  860): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
06-03 01:31:35.438+0900 W/HOME_APPS(  860): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.example/shared/res/1.jpg], Loading state:[1]
06-03 01:31:36.999+0900 E/PKGMGR_SERVER( 9140): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-03 01:31:36.999+0900 E/PKGMGR_SERVER( 9140): pkgmgr-server.c: main(2471) > package manager server terminated.
06-03 01:31:39.962+0900 W/AUL     ( 9208): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.example)
06-03 01:31:39.972+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
06-03 01:31:39.982+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
06-03 01:31:39.982+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
06-03 01:31:39.982+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-03 01:31:39.982+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 9208
06-03 01:31:39.982+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-03 01:31:39.992+0900 E/RESOURCED(  653): block.c: block_prelaunch_state(134) > insert data org.example.example, table num : 9
06-03 01:31:39.992+0900 E/RESOURCED(  653): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 01:31:40.002+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
06-03 01:31:40.002+0900 W/AUL_PAD ( 1359): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-03 01:31:40.002+0900 W/AUL_PAD ( 1359): launchpad.c: __send_result_to_caller(267) > Check app launching
06-03 01:31:40.032+0900 I/CAPI_APPFW_APPLICATION( 8756): app_main.c: ui_app_main(789) > app_efl_main
06-03 01:31:40.032+0900 I/CAPI_APPFW_APPLICATION( 8756): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-03 01:31:40.072+0900 E/TBM     ( 8756): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-03 01:31:40.103+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 8756, appid: org.example.example
06-03 01:31:40.103+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-03 01:31:40.103+0900 W/AUL     ( 9208): launch.c: app_request_to_launchpad(425) > request cmd(0) result(8756)
06-03 01:31:40.263+0900 I/APP_CORE( 8756): appcore-efl.c: __do_app(514) > [APP 8756] Event: RESET State: CREATED
06-03 01:31:40.263+0900 I/CAPI_APPFW_APPLICATION( 8756): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-03 01:31:40.273+0900 E/EFL     ( 8756): edje<8756> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 01:31:40.273+0900 E/EFL     ( 8756): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:31:40.273+0900 E/EFL     ( 8756): edje<8756> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 01:31:40.273+0900 E/EFL     ( 8756): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:31:40.273+0900 E/EFL     ( 8756): edje<8756> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 01:31:40.273+0900 E/EFL     ( 8756): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:31:40.273+0900 E/EFL     ( 8756): edje<8756> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 01:31:40.273+0900 E/EFL     ( 8756): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:31:40.283+0900 E/EFL     ( 8756): edje<8756> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 01:31:40.283+0900 E/EFL     ( 8756): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:31:40.313+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 01:31:40.313+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 01:31:40.353+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 01:31:40.353+0900 W/APP_CORE( 8756): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:b600002
06-03 01:31:40.353+0900 I/Tizen::System( 1210): (259) > Active app [org.exampl], current [com.samsun] 
06-03 01:31:40.353+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 01:31:40.353+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 01:31:40.363+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
06-03 01:31:40.473+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: PAUSE State: RUNNING
06-03 01:31:40.473+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 01:31:40.473+0900 E/cluster-home(  860): homescreen.cpp: OnPause(260) >  app pause
06-03 01:31:40.473+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(4)
06-03 01:31:40.473+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(860)
06-03 01:31:40.473+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: bg
06-03 01:31:40.473+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(8756) status(3)
06-03 01:31:40.483+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 01:31:40.483+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 01:31:40.483+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.example(8756)
06-03 01:31:40.483+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 8756, appid: org.example.example, status: fg
06-03 01:31:40.483+0900 I/CAPI_WIDGET_APPLICATION( 1320): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-03 01:31:40.483+0900 I/CAPI_WIDGET_APPLICATION( 1320): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-03 01:31:40.483+0900 W/AUL     ( 1320): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1320, appid: live-com.samsung.browser, status: bg
06-03 01:31:40.523+0900 I/APP_CORE( 8756): appcore-efl.c: __do_app(514) > [APP 8756] Event: RESUME State: CREATED
06-03 01:31:40.533+0900 I/APP_CORE( 8756): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-03 01:31:40.533+0900 I/APP_CORE( 8756): appcore-efl.c: __do_app(625) > [APP 8756] Initial Launching, call the resume_cb
06-03 01:31:40.533+0900 I/CAPI_APPFW_APPLICATION( 8756): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 01:31:40.843+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(8756) status(0)
06-03 01:31:41.154+0900 I/Tizen::App( 1210): (499) > LaunchedApp(org.example.example)
06-03 01:31:41.154+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3376
06-03 01:31:41.164+0900 I/Tizen::App( 1210): (733) > Finished invoking application event listener for org.example.example, 8756.
06-03 01:31:41.514+0900 E/EFL     ( 8756): ecore_x<8756> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=131681510
06-03 01:31:41.684+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 8756 pgid = 8756
06-03 01:31:41.684+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(143) > dead_pid(8756)
06-03 01:31:41.684+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 01:31:41.734+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-03 01:31:41.734+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-03 01:31:41.734+0900 E/AUL_PAD ( 1359): launchpad.c: main(698) > error reading sigchld info
06-03 01:31:41.734+0900 I/Tizen::App( 1210): (243) > App[org.example.example] pid[8756] terminate event is forwarded
06-03 01:31:41.734+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 01:31:41.734+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [org.example.example, 8756, ]
06-03 01:31:41.734+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 01:31:41.734+0900 I/Tizen::App( 1210): (506) > TerminatedApp(org.example.example)
06-03 01:31:41.734+0900 I/Tizen::App( 1210): (512) > Not registered pid(8756)
06-03 01:31:41.734+0900 I/Tizen::System( 1210): (246) > Terminated app [org.example.example]
06-03 01:31:41.734+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 01:31:41.734+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 8756
06-03 01:31:41.744+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 8756
06-03 01:31:41.744+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 8756
06-03 01:31:41.744+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3377
06-03 01:31:41.754+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
06-03 01:31:41.754+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 01:31:41.754+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 01:31:41.754+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
06-03 01:31:41.754+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
06-03 01:31:41.754+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(0)
06-03 01:31:41.754+0900 E/RESOURCED(  653): datausage-common.c: app_terminated_cb(646) > No classid to terminate!
06-03 01:31:41.774+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 01:31:41.774+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for org.example.example, 8756.
06-03 01:31:41.804+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
06-03 01:31:41.804+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 01:31:41.804+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
06-03 01:31:41.804+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 01:31:41.804+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 01:31:41.814+0900 I/Tizen::System( 1210): (259) > Active app [com.samsun], current [org.exampl] 
06-03 01:31:41.814+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 01:31:41.824+0900 W/CRASH_MANAGER( 9218): worker.c: worker_job(1199) > 1108756657861149642110
