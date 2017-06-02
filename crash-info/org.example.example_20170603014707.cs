S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: example
PID: 10332
Date: 2017-06-03 01:47:07+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 10332, uid 5000)

Register Information
r0   = 0x8000ca66, r1   = 0x00000000
r2   = 0xb282ba70, r3   = 0x8001b6dc
r4   = 0x8001b6dc, r5   = 0xbe8bc2a0
r6   = 0xb2819e61, r7   = 0xbe8bc128
r8   = 0x8001b6dc, r9   = 0xb5f10708
r10  = 0xb81fc918, fp   = 0xbe8bc27c
ip   = 0x80004c27, sp   = 0xbe8bc0f0
lr   = 0x8000ca66, pc   = 0xb2819e80
cpsr = 0x80060030

Memory Information
MemTotal:   987012 KB
MemFree:     39012 KB
Buffers:     15012 KB
Cached:     114480 KB
VmPeak:     120868 KB
VmSize:     112292 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       29008 KB
VmRSS:       27148 KB
VmData:      38224 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35728 KB
VmPTE:          88 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 10332 TID = 10332
10332 10333 10521 10522 

Maps Information
b1312000 b1b11000 rw-p [stack:10522]
b1b8d000 b1b95000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1ba6000 b1ba7000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1bb7000 b1bcb000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1bdf000 b1be0000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1bf0000 b1bf3000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c04000 b1c05000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c15000 b1c17000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c27000 b1c29000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c39000 b1c49000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c59000 b1c65000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c77000 b2476000 rw-p [stack:10521]
b27a7000 b27ae000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27bf000 b27c7000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b27d7000 b27ec000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b27fe000 b2804000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2814000 b281c000 r-xp /opt/usr/apps/org.example.example/bin/example
b2974000 b2a57000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a8e000 b2ab6000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2ac8000 b32c7000 rw-p [stack:10333]
b32c7000 b32c9000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32d9000 b32e3000 r-xp /lib/libnss_files-2.20-2014.11.so
b32f4000 b32fd000 r-xp /lib/libnss_nis-2.20-2014.11.so
b330e000 b331f000 r-xp /lib/libnsl-2.20-2014.11.so
b3332000 b3338000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3349000 b334a000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3372000 b3379000 r-xp /usr/lib/libminizip.so.1.0.0
b3389000 b338e000 r-xp /usr/lib/libstorage.so.0.1
b339e000 b33fd000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3413000 b3427000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3437000 b347b000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b348b000 b3493000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b34a3000 b34d3000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b34e6000 b359f000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b35b3000 b3606000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3617000 b3632000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3642000 b3703000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3716000 b3726000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3736000 b3743000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3754000 b375b000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b376b000 b37ac000 r-xp /usr/lib/libmdm.so.1.2.12
b37bc000 b37c4000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37d3000 b37e3000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3804000 b3864000 r-xp /usr/lib/libasound.so.2.0.0
b3876000 b3879000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3889000 b388c000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b389c000 b38a1000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b38b1000 b38b2000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b38c2000 b38cd000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38e1000 b38e8000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38f8000 b38fe000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b390e000 b3913000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3923000 b393e000 r-xp /usr/lib/libmmfsound.so.0.1.0
b394e000 b3955000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3965000 b3968000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3979000 b39a7000 r-xp /usr/lib/libidn.so.11.5.44
b39b7000 b39cd000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39de000 b39e8000 r-xp /usr/lib/libcares.so.2.1.0
b39f8000 b3a02000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3a12000 b3a14000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a24000 b3a25000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a35000 b3a39000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a4a000 b3a72000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a83000 b3aac000 r-xp /usr/lib/libturbojpeg.so
b3acc000 b3ad2000 r-xp /usr/lib/libgif.so.4.1.6
b3ae2000 b3b28000 r-xp /usr/lib/libcurl.so.4.3.0
b3b39000 b3b5a000 r-xp /usr/lib/libexif.so.12.3.3
b3b75000 b3b8a000 r-xp /usr/lib/libtts.so
b3b9b000 b3ba3000 r-xp /usr/lib/libfeedback.so.0.1.4
b3bb3000 b3c79000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c99000 b3d91000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3db0000 b3e7e000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e95000 b3e97000 r-xp /usr/lib/libboost_system.so.1.51.0
b3ea7000 b3ead000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3ebd000 b3ee0000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3ef1000 b3ef3000 r-xp /usr/lib/libappsvc.so.0.1.0
b3f03000 b3f05000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f16000 b3f1b000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f32000 b3f34000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f44000 b3f4b000 r-xp /usr/lib/libsensord-share.so
b3f5b000 b3f73000 r-xp /usr/lib/libsensor.so.1.1.0
b3f84000 b3f87000 r-xp /usr/lib/libXv.so.1.0.0
b3f97000 b3f9c000 r-xp /usr/lib/libutilX.so.1.1.0
b3fac000 b3fb1000 r-xp /usr/lib/libappcore-common.so.1.1
b3fc1000 b3fc8000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3fdb000 b3fdf000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3ff0000 b40ce000 r-xp /usr/lib/libCOREGL.so.4.0
b40ee000 b40f1000 r-xp /usr/lib/libuuid.so.1.3.0
b4101000 b4118000 r-xp /usr/lib/libblkid.so.1.1.0
b4129000 b412b000 r-xp /usr/lib/libXau.so.6.0.0
b413b000 b4182000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4194000 b419a000 r-xp /usr/lib/libjson-c.so.2.0.1
b41ab000 b41af000 r-xp /usr/lib/libogg.so.0.7.1
b41bf000 b41e1000 r-xp /usr/lib/libvorbis.so.0.4.3
b41f1000 b42d5000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42f1000 b42f4000 r-xp /usr/lib/libEGL.so.1.4
b4305000 b430b000 r-xp /usr/lib/libxcb-render.so.0.0.0
b431b000 b431d000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b432d000 b433a000 r-xp /usr/lib/libGLESv2.so.2.0
b434b000 b43ad000 r-xp /usr/lib/libpixman-1.so.0.28.2
b43c2000 b43da000 r-xp /usr/lib/libmount.so.1.1.0
b43ec000 b4400000 r-xp /usr/lib/libxcb.so.1.1.0
b4410000 b4417000 r-xp /lib/libcrypt-2.20-2014.11.so
b444f000 b4451000 r-xp /usr/lib/libiri.so
b4461000 b446c000 r-xp /usr/lib/libgpg-error.so.0.15.0
b447d000 b44b3000 r-xp /usr/lib/libpulse.so.0.16.2
b44c4000 b4507000 r-xp /usr/lib/libsndfile.so.1.0.25
b451c000 b4531000 r-xp /lib/libexpat.so.1.5.2
b4543000 b4601000 r-xp /usr/lib/libcairo.so.2.11200.14
b4615000 b461d000 r-xp /usr/lib/libdrm.so.2.4.0
b462d000 b4630000 r-xp /usr/lib/libdri2.so.0.0.0
b4640000 b468e000 r-xp /usr/lib/libssl.so.1.0.0
b46a3000 b46af000 r-xp /usr/lib/libeeze.so.1.13.0
b46c0000 b46c9000 r-xp /usr/lib/libethumb.so.1.13.0
b46d9000 b46dc000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46ec000 b48a3000 r-xp /usr/lib/libcrypto.so.1.0.0
b568e000 b5697000 r-xp /usr/lib/libXi.so.6.1.0
b56a7000 b56a9000 r-xp /usr/lib/libXgesture.so.7.0.0
b56b9000 b56bd000 r-xp /usr/lib/libXtst.so.6.1.0
b56cd000 b56d3000 r-xp /usr/lib/libXrender.so.1.3.0
b56e3000 b56e9000 r-xp /usr/lib/libXrandr.so.2.2.0
b56f9000 b56fb000 r-xp /usr/lib/libXinerama.so.1.0.0
b570c000 b570f000 r-xp /usr/lib/libXfixes.so.3.1.0
b571f000 b572a000 r-xp /usr/lib/libXext.so.6.4.0
b573a000 b573c000 r-xp /usr/lib/libXdamage.so.1.1.0
b574c000 b574e000 r-xp /usr/lib/libXcomposite.so.1.0.0
b575e000 b5840000 r-xp /usr/lib/libX11.so.6.3.0
b5854000 b585b000 r-xp /usr/lib/libXcursor.so.1.0.2
b586b000 b5883000 r-xp /usr/lib/libudev.so.1.6.0
b5885000 b5888000 r-xp /lib/libattr.so.1.1.0
b5898000 b58b8000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58b9000 b58be000 r-xp /usr/lib/libffi.so.6.0.2
b58cf000 b58e7000 r-xp /lib/libz.so.1.2.8
b58f7000 b58f9000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5909000 b59de000 r-xp /usr/lib/libxml2.so.2.9.2
b59f3000 b5a8e000 r-xp /usr/lib/libstdc++.so.6.0.20
b5aaa000 b5aad000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5abd000 b5ad6000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5ae7000 b5af8000 r-xp /lib/libresolv-2.20-2014.11.so
b5b0c000 b5b86000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b9b000 b5b9d000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bad000 b5bb4000 r-xp /usr/lib/libembryo.so.1.13.0
b5bc4000 b5bce000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5bdf000 b5bf7000 r-xp /usr/lib/libpng12.so.0.50.0
b5c08000 b5c2b000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c4c000 b5c60000 r-xp /usr/lib/libector.so.1.13.0
b5c71000 b5c89000 r-xp /usr/lib/liblua-5.1.so
b5c9a000 b5cf1000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d05000 b5d2d000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d3e000 b5d51000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d62000 b5d9c000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5dad000 b5dbb000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5dcb000 b5dd3000 r-xp /usr/lib/libtbm.so.1.0.0
b5de3000 b5df0000 r-xp /usr/lib/libeio.so.1.13.0
b5e00000 b5e02000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e12000 b5e17000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e27000 b5e3e000 r-xp /usr/lib/libefreet.so.1.13.0
b5e50000 b5e70000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e80000 b5ea0000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ea2000 b5ea8000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5eb8000 b5ec9000 r-xp /usr/lib/libemotion.so.1.13.0
b5eda000 b5ee1000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ef1000 b5f00000 r-xp /usr/lib/libeo.so.1.13.0
b5f11000 b5f23000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f34000 b5f39000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f49000 b5f62000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f72000 b5f8f000 r-xp /usr/lib/libeet.so.1.13.0
b5fa8000 b5ff0000 r-xp /usr/lib/libeina.so.1.13.0
b6001000 b6011000 r-xp /usr/lib/libefl.so.1.13.0
b6022000 b6107000 r-xp /usr/lib/libicuuc.so.51.1
b6124000 b6264000 r-xp /usr/lib/libicui18n.so.51.1
b627b000 b62b3000 r-xp /usr/lib/libecore_x.so.1.13.0
b62c5000 b62c8000 r-xp /lib/libcap.so.2.21
b62d8000 b6301000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6312000 b6319000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b632b000 b6362000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6373000 b645e000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6471000 b64ea000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64fc000 b6501000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6511000 b651b000 r-xp /usr/lib/libvconf.so.0.2.45
b652b000 b652d000 r-xp /usr/lib/libvasum.so.0.3.1
b653d000 b653f000 r-xp /usr/lib/libttrace.so.1.1
b654f000 b6552000 r-xp /usr/lib/libiniparser.so.0
b6562000 b6588000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6598000 b659d000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65ae000 b65c5000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65d6000 b6641000 r-xp /lib/libm-2.20-2014.11.so
b6652000 b6658000 r-xp /lib/librt-2.20-2014.11.so
b6669000 b6676000 r-xp /usr/lib/libunwind.so.8.0.1
b66ac000 b67d0000 r-xp /lib/libc-2.20-2014.11.so
b67e5000 b67fe000 r-xp /lib/libgcc_s-4.9.so.1
b680e000 b68f0000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6901000 b692b000 r-xp /usr/lib/libdbus-1.so.3.8.12
b693c000 b6978000 r-xp /usr/lib/libsystemd.so.0.4.0
b697a000 b69fd000 r-xp /usr/lib/libedje.so.1.13.0
b6a10000 b6a2e000 r-xp /usr/lib/libecore.so.1.13.0
b6a4e000 b6bd5000 r-xp /usr/lib/libevas.so.1.13.0
b6c0a000 b6c1e000 r-xp /lib/libpthread-2.20-2014.11.so
b6c32000 b6e66000 r-xp /usr/lib/libelementary.so.1.13.0
b6e95000 b6e99000 r-xp /usr/lib/libsmack.so.1.0.0
b6ea9000 b6eb0000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6ec0000 b6ec2000 r-xp /usr/lib/libdlog.so.0.0.0
b6ed2000 b6ed5000 r-xp /usr/lib/libbundle.so.0.1.22
b6ee5000 b6ee7000 r-xp /lib/libdl-2.20-2014.11.so
b6ef8000 b6f10000 r-xp /usr/lib/libaul.so.0.1.0
b6f24000 b6f29000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f3a000 b6f47000 r-xp /usr/lib/liblptcp.so
b6f59000 b6f5d000 r-xp /usr/lib/libsys-assert.so
b6f6e000 b6f8e000 r-xp /lib/ld-2.20-2014.11.so
b6f9f000 b6fa4000 r-xp /usr/bin/launchpad-loader
b7fa2000 b825b000 rw-p [heap]
be89c000 be8bd000 rw-p [stack]
End of Maps Information

Callstack Information (PID:10332)
Call Stack Count: 18
 0: setting_view_cb + 0x1f (0xb2819e80) [/opt/usr/apps/org.example.example/bin/example] + 0x5e80
 1: (0xb6a83175) [/usr/lib/libevas.so.1] + 0x35175
 2: (0xb5efc219) [/usr/lib/libeo.so.1] + 0xb219
 3: eo_event_callback_call + 0x68 (0xb5efafb9) [/usr/lib/libeo.so.1] + 0x9fb9
 4: (0xb6a83515) [/usr/lib/libevas.so.1] + 0x35515
 5: (0xb6a8b725) [/usr/lib/libevas.so.1] + 0x3d725
 6: evas_canvas_event_feed_mouse_down + 0x6a (0xb6a90f6b) [/usr/lib/libevas.so.1] + 0x42f6b
 7: evas_event_feed_mouse_down + 0x30 (0xb6a94939) [/usr/lib/libevas.so.1] + 0x46939
 8: (0xb46db173) [/usr/lib/libecore_input_evas.so.1] + 0x2173
 9: (0xb6a1bc4b) [/usr/lib/libecore.so.1] + 0xbc4b
10: (0xb6a21a5d) [/usr/lib/libecore.so.1] + 0x11a5d
11: ecore_main_loop_begin + 0x3e (0xb6a21c83) [/usr/lib/libecore.so.1] + 0x11c83
12: appcore_efl_main + 0x20c (0xb6f272bd) [/usr/lib/libappcore-efl.so.1] + 0x32bd
13: ui_app_main + 0xc0 (0xb3fdd909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
14: main + 0x10e (0xb2819677) [/opt/usr/apps/org.example.example/bin/example] + 0x5677
15: (0xb6fa0bb5) [/opt/usr/apps/org.example.example/bin/example] + 0x1bb5
16: __libc_start_main + 0x114 (0xb66c24bc) [/lib/libc.so.6] + 0x164bc
17: (0xb6fa0eb4) [/opt/usr/apps/org.example.example/bin/example] + 0x1eb4
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
n.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-03 01:46:51.221+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 01:46:51.241+0900 I/Tizen::System( 1210): (280) > The screen has been turned on.
06-03 01:46:51.241+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 01:46:51.241+0900 E/GAME    ( 2577): .\..\src\TizenImpl.c: device_display_changed_cb(80) > device_display_changed_cb: state change to 0
06-03 01:46:51.281+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 01:46:51.281+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 01:46:51.281+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 01:46:51.281+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 01:46:51.281+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 01:46:51.291+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 01:46:51.291+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 01:46:51.301+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_update_cb(287) > received updating signal
06-03 01:46:51.301+0900 W/LOCKSCREEN(  845): dbus.c: _dbus_message_recv_cb(154) > [_dbus_message_recv_cb:154:W] POST_LCD_ON status 2 visibility(1)
06-03 01:46:51.372+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-03 01:46:51.372+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 01:46:52.112+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=132592108
06-03 01:46:52.212+0900 E/weather-agent(10396): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
06-03 01:46:52.212+0900 I/CAPI_APPFW_APPLICATION(10396): service_app_main.c: service_app_exit(446) > service_app_exit
06-03 01:46:52.302+0900 I/Tizen::Net::Wifi( 1210): (941) > The background scan result updated.
06-03 01:46:52.322+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
06-03 01:46:52.322+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
06-03 01:46:52.322+0900 E/weather-agent(10396): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
06-03 01:46:52.473+0900 W/AUL_AMD (  610): amd_request.c: __send_app_termination_signal(609) > send dead signal done
06-03 01:46:52.473+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 10396
06-03 01:46:52.473+0900 I/Tizen::App( 1210): (243) > App[com.samsung.weather-m-agent] pid[10396] terminate event is forwarded
06-03 01:46:52.473+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 01:46:52.473+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 10396, ]
06-03 01:46:52.473+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 01:46:52.473+0900 I/Tizen::App( 1210): (506) > TerminatedApp(com.samsung.weather-m-agent)
06-03 01:46:52.473+0900 I/Tizen::App( 1210): (512) > Not registered pid(10396)
06-03 01:46:52.473+0900 I/Tizen::System( 1210): (246) > Terminated app [com.samsung.weather-m-agent]
06-03 01:46:52.473+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 01:46:52.473+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 10396
06-03 01:46:52.483+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 01:46:52.483+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 10396.
06-03 01:46:52.913+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=132592915
06-03 01:46:52.923+0900 E/LOCKSCREEN(  845): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
06-03 01:46:52.923+0900 E/LOCKSCREEN(  845): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-03 01:46:53.604+0900 E/PKGMGR  (10445): pkgmgr.c: pkgmgr_client_uninstall(2142) > uninstall pkg start.
06-03 01:46:53.694+0900 E/PKGMGR_SERVER(10447): pkgmgr-server.c: main(2414) > package manager server start
06-03 01:46:53.734+0900 E/PKGMGR_SERVER(10447): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
06-03 01:46:53.734+0900 E/PKGMGR_SERVER(10447): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [org.example.example]
06-03 01:46:53.744+0900 E/PKGMGR  (10445): pkgmgr.c: pkgmgr_client_uninstall(2270) > uninstall pkg finish, ret=[104450002]
06-03 01:46:53.874+0900 E/rpm-installer(10450): rpm-cmdline.c: __ri_is_core_tpk_app(302) > This is a core tpk app.
06-03 01:46:53.924+0900 I/Tizen::App( 1210): (1894) > PackageEventHandler - req: 12100002, pkg_type: tpk, pkg_name: org.example.example, key: start, val: uninstall
06-03 01:46:53.924+0900 I/Tizen::App( 1210): (1584) > Package = [org.example.example], Key = [start], Value = [uninstall], install = [1]
06-03 01:46:53.924+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:46:53.924+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:46:53.924+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:46:53.924+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:46:53.924+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
06-03 01:46:53.934+0900 I/SYNCSERVICE(  945): SyncManager_SyncManager.cpp: OnPackageUninstalled(403) > OnPackageUninstalled [type tpk] type [pkdId:org.example.example]
06-03 01:46:53.934+0900 W/AUL_AMD (  610): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
06-03 01:46:53.934+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
06-03 01:46:53.944+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.example]
06-03 01:46:53.944+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.example]
06-03 01:46:53.944+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
06-03 01:46:53.944+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
06-03 01:46:53.944+0900 E/rpm-installer(10450): rpm-installer.c: __ri_check_running_app(2267) > app[org.example.example] , running state[0].
06-03 01:46:53.964+0900 I/SYNCSERVICE(  945): SyncManager_SyncManager.cpp: OnPackageUninstalled(403) > OnPackageUninstalled [type tpk] type [pkdId:org.example.example]
06-03 01:46:54.034+0900 E/PKGMGR_PARSER(10450): pkgmgr_parser.c: __check_theme(154) > theme for uninstallation.
06-03 01:46:54.054+0900 I/PRIVACY-MANAGER-CLIENT(10450): SocketClient.cpp: SocketClient(37) > Client created
06-03 01:46:54.054+0900 I/PRIVACY-MANAGER-CLIENT(10450): SocketClient.cpp: connect(62) > Client connected
06-03 01:46:54.054+0900 I/PRIVACY-MANAGER-SERVER(  906): SocketService.cpp: mainloop(230) > Got incoming connection
06-03 01:46:54.054+0900 I/PRIVACY-MANAGER-CLIENT(10450): SocketClient.cpp: disconnect(72) > Client disconnected
06-03 01:46:54.054+0900 E/PKGMGR_CERT(10450): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
06-03 01:46:54.064+0900 E/PKGMGR_CERT(10450): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
06-03 01:46:54.064+0900 E/PKGMGR_CERT(10450): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
06-03 01:46:54.144+0900 E/PKGMGR_CERT(10450): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
06-03 01:46:54.144+0900 E/PKGMGR_CERT(10450): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
06-03 01:46:54.144+0900 E/PKGMGR_CERT(10450): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
06-03 01:46:54.144+0900 E/rpm-installer(10450): rpm-installer.c: _rpm_uninstall_pkg_with_dbpath(3415) > success
06-03 01:46:54.144+0900 E/rpm-installer(10450): rpm-installer.c: _rpm_uninstall_pkg_with_dbpath(3416) > try to classify and delete residual files
06-03 01:46:56.006+0900 E/PKGMGR_SERVER(10447): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
06-03 01:46:56.046+0900 I/Tizen::App( 1210): (1894) > PackageEventHandler - req: 12100002, pkg_type: tpk, pkg_name: org.example.example, key: end, val: ok
06-03 01:46:56.046+0900 I/Tizen::App( 1210): (83) > Uninstallation is Completed. [Package = org.example.example]
06-03 01:46:56.046+0900 I/Tizen::App( 1210): (709) > Enter. package(org.example.example), uninstallationResult(1)
06-03 01:46:56.046+0900 E/PKGMGR_SERVER(10447): pkgmgr-server.c: sighandler(417) > child NORMAL exit [10450]
06-03 01:46:56.046+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:46:56.046+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:46:56.046+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:46:56.046+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:46:56.056+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
06-03 01:46:56.056+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
06-03 01:46:56.056+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
06-03 01:46:56.056+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.example]
06-03 01:46:56.056+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _DoPkgJob(494) >  #8
06-03 01:46:56.056+0900 E/PUSHD   ( 1001): db.c: _get_app_info_by_query(361) > DB step: 101 [unknown error]
06-03 01:46:56.066+0900 I/SYNCSERVICE(  945): SyncManager_SyncManager.cpp: OnPackageUninstalled(403) > OnPackageUninstalled [type tpk] type [pkdId:org.example.example]
06-03 01:46:56.066+0900 I/SYNCSERVICE(  945): SyncManager_SyncAdapterAggregator.cpp: HandlePackageUninstalled(129) > Removing sync adapter for package [org.example.example]
06-03 01:46:56.066+0900 I/SYNCSERVICE(  945): SyncManager_SyncJobsAggregator.cpp: HandlePackageUninstalled(197) > Sync jobs for package org.example.example are not found
06-03 01:46:56.066+0900 E/PUSHD   ( 1001): db.c: db_reg_get_by_tizen_pkg_id(438) > Fail to get app_info
06-03 01:46:56.066+0900 E/Tizen::App( 1210): (1141) > [E_PKG_NOT_INSTALLED] pkgmgrinfo_pkginfo_get_pkginfo() is failed. result=[-1], package=[org.example.example]
06-03 01:46:56.066+0900 E/Tizen::App( 1210): (278) > [E_PKG_NOT_INSTALLED] package (org.example.example) is not found.
06-03 01:46:56.066+0900 E/Tizen::App( 1210): (2193) > GetPackageInfoN(org.example.example) failed.
06-03 01:46:56.066+0900 I/Tizen::App( 1210): (720) > Exit.
06-03 01:46:56.066+0900 I/Tizen::App( 1210): (1584) > Package = [org.example.example], Key = [end], Value = [ok], install = [0]
06-03 01:46:56.066+0900 I/Tizen::App( 1210): (840) > Enter.
06-03 01:46:56.066+0900 I/Tizen::App( 1210): (883) > Exit.
06-03 01:46:56.066+0900 W/AUL_AMD (  610): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1104) > g_hash_table_foreach_remove, 1
06-03 01:46:56.106+0900 E/PKGMGR_INFO(  860): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_filter_foreach_pkginfo(2152) > where = package_info.package_support_disable IN ('true','True') and package_info.package_nodisplay IN ('false','False') and package_info.package_disable IN ('true','True')
06-03 01:46:56.106+0900 E/PKGMGR_INFO(  860): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_filter_foreach_pkginfo(2158) > query = select * from package_info LEFT OUTER JOIN package_localized_info ON package_info.package=package_localized_info.package and package_localized_info.package_locale IN ('No Locale', 'ko-kr') where package_info.package_support_disable IN ('true','True') and package_info.package_nodisplay IN ('false','False') and package_info.package_disable IN ('true','True')
06-03 01:46:56.276+0900 E/PKGMGR  (10457): pkgmgr.c: pkgmgr_client_install(1605) > install pkg start.
06-03 01:46:56.316+0900 E/PKGMGR_SERVER(10447): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.example-1.0.0-arm.tpk]
06-03 01:46:56.326+0900 E/PKGMGR_INFO(10447): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.example-1.0.0-arm.tpk] not found in DB
06-03 01:46:56.336+0900 E/rpm-installer(10447): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
06-03 01:46:56.346+0900 E/PKGMGR_SERVER(10447): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
06-03 01:46:56.346+0900 E/PKGMGR  (10457): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[104570002]
06-03 01:46:56.467+0900 E/PKGMGR_INSTALLER(10459): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
06-03 01:46:56.467+0900 E/rpm-installer(10459): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.example-1.0.0-arm.tpk] is tpk package.
06-03 01:46:56.487+0900 E/rpm-installer(10459): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
06-03 01:46:56.487+0900 E/rpm-installer(10459): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
06-03 01:46:56.487+0900 E/rpm-installer(10459): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
06-03 01:46:56.487+0900 E/rpm-installer(10459): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
06-03 01:46:56.487+0900 E/rpm-installer(10459): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
06-03 01:46:56.547+0900 W/CERT_SVC_VCORE(10459): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
06-03 01:46:56.597+0900 I/Tizen::App( 1210): (1894) > PackageEventHandler - req: 12100002, pkg_type: tpk, pkg_name: org.example.example, key: start, val: install
06-03 01:46:56.597+0900 I/Tizen::App( 1210): (1584) > Package = [org.example.example], Key = [start], Value = [install], install = [96]
06-03 01:46:56.597+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:46:56.607+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:46:56.607+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:46:56.607+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:46:56.607+0900 I/Tizen::App( 1210): (1894) > PackageEventHandler - req: 12100002, pkg_type: tpk, pkg_name: org.example.example, key: install_percent, val: 30
06-03 01:46:56.607+0900 I/Tizen::App( 1210): (119) > InstallationInProgress [30]
06-03 01:46:56.607+0900 I/Tizen::App( 1210): (1584) > Package = [org.example.example], Key = [install_percent], Value = [30], install = [96]
06-03 01:46:56.617+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:46:56.617+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:46:56.617+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:46:56.617+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:46:56.817+0900 E/rpm-installer(10459): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
06-03 01:46:56.817+0900 E/rpm-installer(10459): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
06-03 01:46:56.817+0900 E/rpm-installer(10459): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
06-03 01:46:56.817+0900 E/rpm-installer(10459): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
06-03 01:46:56.817+0900 E/rpm-installer(10459): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
06-03 01:46:56.817+0900 E/rpm-installer(10459): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
06-03 01:46:56.817+0900 E/PKGMGR_PARSER(10459): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
06-03 01:46:56.827+0900 E/PKGMGR_PARSER(10459): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
06-03 01:46:56.857+0900 I/PRIVACY-MANAGER-CLIENT(10459): SocketClient.cpp: SocketClient(37) > Client created
06-03 01:46:57.077+0900 E/PKGMGR_PARSER(10459): pkgmgr_parser.c: __check_theme(142) > theme for installation.
06-03 01:46:57.097+0900 E/PKGMGR_CERT(10459): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
06-03 01:46:57.097+0900 E/PKGMGR_CERT(10459): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 107
06-03 01:46:57.097+0900 E/PKGMGR_CERT(10459): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 107
06-03 01:46:57.097+0900 E/PKGMGR_CERT(10459): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 44 2
06-03 01:46:57.097+0900 E/PKGMGR_CERT(10459): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 45 2
06-03 01:46:57.097+0900 E/PKGMGR_CERT(10459): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 46 2
06-03 01:46:57.097+0900 E/PKGMGR_CERT(10459): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 47 2
06-03 01:46:57.107+0900 E/PKGMGR_CERT(10459): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
06-03 01:46:57.107+0900 E/rpm-installer(10459): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1956) > skip! empty dirpath=[/opt/usr/apps/org.example.example/lib]
06-03 01:46:57.107+0900 I/Tizen::App( 1210): (1894) > PackageEventHandler - req: 12100002, pkg_type: tpk, pkg_name: org.example.example, key: install_percent, val: 60
06-03 01:46:57.107+0900 I/Tizen::App( 1210): (119) > InstallationInProgress [60]
06-03 01:46:57.107+0900 I/Tizen::App( 1210): (1584) > Package = [org.example.example], Key = [install_percent], Value = [60], install = [96]
06-03 01:46:57.107+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:46:57.107+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:46:57.117+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:46:57.117+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:46:57.127+0900 E/rpm-installer(10459): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
06-03 01:46:57.157+0900 E/rpm-installer(10459): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
06-03 01:46:57.167+0900 I/Tizen::App( 1210): (1894) > PackageEventHandler - req: 12100002, pkg_type: tpk, pkg_name: org.example.example, key: install_percent, val: 100
06-03 01:46:57.167+0900 I/Tizen::App( 1210): (119) > InstallationInProgress [100]
06-03 01:46:57.167+0900 I/Tizen::App( 1210): (1584) > Package = [org.example.example], Key = [install_percent], Value = [100], install = [96]
06-03 01:46:57.167+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:46:57.167+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:46:57.167+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:46:57.167+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:46:57.317+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-03 01:46:57.998+0900 E/PKGMGR_SERVER(10447): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
06-03 01:46:59.249+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
06-03 01:46:59.249+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
06-03 01:46:59.249+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
06-03 01:46:59.259+0900 I/Tizen::App( 1210): (1894) > PackageEventHandler - req: 12100002, pkg_type: tpk, pkg_name: org.example.example, key: end, val: ok
06-03 01:46:59.259+0900 I/Tizen::App( 1210): (78) > Installation is Completed. [Package = org.example.example]
06-03 01:46:59.259+0900 I/Tizen::App( 1210): (671) > Enter. package(org.example.example), installationResult(0)
06-03 01:46:59.289+0900 W/ISF_PANEL_EFL(  768): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
06-03 01:46:59.309+0900 I/Tizen::App( 1210): (1360) > package(org.example.example), version(1.0.0), type(tpk), displayName(forpet), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.example), storeClient(), appRootPath(/opt/usr/apps/org.example.example)
06-03 01:46:59.319+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:46:59.329+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:46:59.329+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:46:59.329+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:46:59.329+0900 I/Tizen::App( 1210): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.example]
06-03 01:46:59.349+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.example]
06-03 01:46:59.349+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.example]
06-03 01:46:59.349+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
06-03 01:46:59.349+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
06-03 01:46:59.349+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.example]
06-03 01:46:59.359+0900 E/PKGMGR_SERVER(10447): pkgmgr-server.c: sighandler(417) > child NORMAL exit [10459]
06-03 01:46:59.369+0900 I/Tizen::App( 1210): (416) > appName = [example]
06-03 01:46:59.369+0900 I/Tizen::App( 1210): (509) > exe = [/opt/usr/apps/org.example.example/bin/example], displayName = [forpet], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-03 01:46:59.369+0900 E/PKGMGR_INFO( 1210): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
06-03 01:46:59.369+0900 I/Tizen::App( 1210): (683) > Application count(1) in this package
06-03 01:46:59.369+0900 I/Tizen::App( 1210): (703) > Exit.
06-03 01:46:59.369+0900 I/Tizen::App( 1210): (1584) > Package = [org.example.example], Key = [end], Value = [ok], install = [1]
06-03 01:46:59.369+0900 I/Tizen::App( 1210): (840) > Enter.
06-03 01:46:59.379+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[forpet] enable[1] system[0]
06-03 01:46:59.379+0900 E/HOME_APPS(  860): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.example] mdm is not enabled
06-03 01:46:59.389+0900 I/Tizen::App( 1210): (416) > appName = [example]
06-03 01:46:59.389+0900 I/Tizen::App( 1210): (509) > exe = [/opt/usr/apps/org.example.example/bin/example], displayName = [forpet], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-03 01:46:59.389+0900 E/cluster-home(  860): mainmenu-data-manager.cpp: GetBoxDataByAppId(2539) >  cannot find box with appid[org.example.example]
06-03 01:46:59.389+0900 I/Tizen::App( 1210): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.example.info]
06-03 01:46:59.389+0900 I/Tizen::App( 1210): (131) > Enter
06-03 01:46:59.389+0900 I/Tizen::App( 1210): (137) > org.example.example does not have launch condition
06-03 01:46:59.389+0900 I/Tizen::App( 1210): (883) > Exit.
06-03 01:46:59.409+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[forpet] enable[1] system[0]
06-03 01:46:59.419+0900 E/util-view(  860): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
06-03 01:46:59.429+0900 E/util-view(  860): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
06-03 01:46:59.730+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=132599734
06-03 01:46:59.800+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=132599799
06-03 01:46:59.800+0900 E/LOCKSCREEN(  845): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
06-03 01:46:59.800+0900 E/LOCKSCREEN(  845): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-03 01:47:00.000+0900 E/PKGMGR_SERVER(10447): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-03 01:47:00.000+0900 E/PKGMGR_SERVER(10447): pkgmgr-server.c: main(2471) > package manager server terminated.
06-03 01:47:00.631+0900 I/INDICATOR(  646): clock.c: indicator_clock_changed_cb(195) > ""
06-03 01:47:00.641+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=132600627
06-03 01:47:00.671+0900 E/UXT     (  646): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 1:47
06-03 01:47:00.671+0900 I/INDICATOR(  646): clock.c: getTimeFormatted(176) > "time format : 오전 1:47"
06-03 01:47:00.671+0900 I/INDICATOR(  646): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 1:47"
06-03 01:47:00.671+0900 W/INDICATOR(  646): clock.c: indicator_clock_changed_cb(272) > 
06-03 01:47:00.681+0900 I/INDICATOR(  646): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146252816 Time: <font_size=31> </font_size> <font_size=31> 오전 1:47</font_size></font>"
06-03 01:47:00.701+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=132600703
06-03 01:47:00.701+0900 E/LOCKSCREEN(  845): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
06-03 01:47:00.701+0900 E/LOCKSCREEN(  845): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-03 01:47:00.971+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=132600973
06-03 01:47:01.021+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=132601028
06-03 01:47:01.031+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=132601028
06-03 01:47:01.031+0900 E/LOCKSCREEN(  845): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
06-03 01:47:01.031+0900 E/LOCKSCREEN(  845): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-03 01:47:01.081+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=132601082
06-03 01:47:01.081+0900 E/LOCKSCREEN(  845): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
06-03 01:47:01.081+0900 E/LOCKSCREEN(  845): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-03 01:47:01.301+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=132601301
06-03 01:47:01.351+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=132601355
06-03 01:47:01.351+0900 E/LOCKSCREEN(  845): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
06-03 01:47:01.361+0900 E/LOCKSCREEN(  845): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-03 01:47:01.541+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=132601531
06-03 01:47:01.632+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=132601628
06-03 01:47:01.642+0900 E/LOCKSCREEN(  845): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
06-03 01:47:01.642+0900 E/LOCKSCREEN(  845): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-03 01:47:02.042+0900 I/Tizen::Net::Wifi( 1210): (941) > The background scan result updated.
06-03 01:47:03.363+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=132603365
06-03 01:47:03.583+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=132603572
06-03 01:47:03.583+0900 E/LOCKSCREEN(  845): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
06-03 01:47:03.593+0900 E/LOCKSCREEN(  845): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-03 01:47:04.114+0900 W/AUL     (10514): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.example)
06-03 01:47:04.124+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
06-03 01:47:04.134+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
06-03 01:47:04.144+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
06-03 01:47:04.144+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-03 01:47:04.144+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 10514
06-03 01:47:04.144+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-03 01:47:04.154+0900 E/RESOURCED(  653): block.c: block_prelaunch_state(134) > insert data org.example.example, table num : 9
06-03 01:47:04.154+0900 E/RESOURCED(  653): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 01:47:04.164+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
06-03 01:47:04.164+0900 W/AUL_PAD ( 1359): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-03 01:47:04.164+0900 W/AUL_PAD ( 1359): launchpad.c: __send_result_to_caller(267) > Check app launching
06-03 01:47:04.184+0900 I/CAPI_APPFW_APPLICATION(10332): app_main.c: ui_app_main(789) > app_efl_main
06-03 01:47:04.184+0900 I/CAPI_APPFW_APPLICATION(10332): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-03 01:47:04.214+0900 E/TBM     (10332): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-03 01:47:04.264+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 10332, appid: org.example.example
06-03 01:47:04.264+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-03 01:47:04.264+0900 W/AUL     (10514): launch.c: app_request_to_launchpad(425) > request cmd(0) result(10332)
06-03 01:47:04.364+0900 I/APP_CORE(10332): appcore-efl.c: __do_app(514) > [APP 10332] Event: RESET State: CREATED
06-03 01:47:04.364+0900 I/CAPI_APPFW_APPLICATION(10332): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-03 01:47:04.364+0900 E/EFL     (10332): edje<10332> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 01:47:04.364+0900 E/EFL     (10332): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:47:04.374+0900 E/EFL     (10332): edje<10332> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 01:47:04.374+0900 E/EFL     (10332): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:47:04.374+0900 E/EFL     (10332): edje<10332> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 01:47:04.374+0900 E/EFL     (10332): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:47:04.374+0900 E/EFL     (10332): edje<10332> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 01:47:04.374+0900 E/EFL     (10332): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:47:04.374+0900 E/EFL     (10332): edje<10332> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 01:47:04.374+0900 E/EFL     (10332): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:47:04.434+0900 W/APP_CORE(10332): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:7000002
06-03 01:47:04.434+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
06-03 01:47:04.544+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(10332) status(4)
06-03 01:47:04.574+0900 I/APP_CORE(10332): appcore-efl.c: __do_app(514) > [APP 10332] Event: PAUSE State: CREATED
06-03 01:47:04.594+0900 I/TIZEN_N_EFL_UTIL_WINDOW(10332): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 15
06-03 01:47:04.594+0900 E/APP_CORE(10332): appcore-efl.c: _capture_and_make_file(1619) > win[7000002] widget[720] height[1280]
06-03 01:47:04.594+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 33
06-03 01:47:04.905+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(10332) status(0)
06-03 01:47:05.265+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 01:47:05.265+0900 W/AUL_AMD (  610): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
06-03 01:47:05.315+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3516
06-03 01:47:05.325+0900 I/Tizen::App( 1210): (499) > LaunchedApp(org.example.example)
06-03 01:47:05.325+0900 I/Tizen::App( 1210): (733) > Finished invoking application event listener for org.example.example, 10332.
06-03 01:47:05.615+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=132605615
06-03 01:47:05.716+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=132605713
06-03 01:47:05.716+0900 E/LOCKSCREEN(  845): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
06-03 01:47:05.726+0900 E/LOCKSCREEN(  845): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-03 01:47:06.276+0900 I/UXT     (10523): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-03 01:47:06.496+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=132606504
06-03 01:47:06.596+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=132606601
06-03 01:47:06.596+0900 E/LOCKSCREEN(  845): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
06-03 01:47:06.596+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80001:VIEW_GESTURED
06-03 01:47:06.596+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80001 event_info:0
06-03 01:47:06.596+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
06-03 01:47:06.596+0900 W/LOCKSCREEN(  845): view-mgr.c: _event_route(130) > [_event_route:130:W] event:80001 event_info:0
06-03 01:47:06.596+0900 W/LOCKSCREEN(  845): view-mgr.c: _state_transit(46) > [_state_transit:46:W] state transit:2
06-03 01:47:06.596+0900 W/LOCKSCREEN(  845): view-mgr.c: _state_transit(49) > [_state_transit:49:W] already in same state:2
06-03 01:47:06.596+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:4:LKD_EVT_WILL_UNLOCK
06-03 01:47:06.596+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:4 event_info:0
06-03 01:47:06.596+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event_delay(1041) > [lockd_event_delay:1041:W] dealyed event:2:UNLOCK wait for:0.330000
06-03 01:47:06.596+0900 E/LOCKSCREEN(  845): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-03 01:47:06.937+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:2 event_info:0
06-03 01:47:06.937+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:7
06-03 01:47:06.937+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] RESUME => HIDE
06-03 01:47:06.937+0900 E/LOCKSCREEN(  845): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
06-03 01:47:06.937+0900 E/LOCKSCREEN(  845): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-03 01:47:06.937+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 01:47:06.937+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-03 01:47:06.937+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-03 01:47:06.937+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
06-03 01:47:06.947+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 01:47:06.957+0900 I/APP_CORE(10332): appcore-efl.c: __do_app(514) > [APP 10332] Event: RESUME State: CREATED
06-03 01:47:06.957+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 01:47:06.957+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(845) status(4)
06-03 01:47:06.957+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.lockscreen(845)
06-03 01:47:06.957+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 845, appid: com.samsung.lockscreen, status: bg
06-03 01:47:06.957+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(10332) status(3)
06-03 01:47:06.967+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 01:47:06.967+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 01:47:06.967+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.example(10332)
06-03 01:47:06.967+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 10332, appid: org.example.example, status: fg
06-03 01:47:06.987+0900 I/APP_CORE(10332): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-03 01:47:06.997+0900 I/APP_CORE(10332): appcore-efl.c: __do_app(625) > [APP 10332] Initial Launching, call the resume_cb
06-03 01:47:06.997+0900 I/CAPI_APPFW_APPLICATION(10332): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 01:47:06.997+0900 W/LOCKSCREEN(  845): lockscreen.c: _window_visibility_cb(344) > [_window_visibility_cb:344:W] Window [0x2E00007] is [invisible]
06-03 01:47:06.997+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:10002:WIN_BECOME_INVISIBLE
06-03 01:47:06.997+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:10002 event_info:0
06-03 01:47:06.997+0900 I/Tizen::System( 1210): (259) > Active app [org.exampl], current [com.samsun] 
06-03 01:47:07.007+0900 E/LOCKSCREEN(  845): util-daemon.c: _lock_state_timer_cb(56) > [_lock_state_timer_cb:56:E] ########## LOCK STATE SET : VCONFKEY_IDLE_UNLOCK ##########
06-03 01:47:07.007+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: PAUSE State: RUNNING
06-03 01:47:07.007+0900 I/CAPI_APPFW_APPLICATION(  845): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 01:47:07.007+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 01:47:07.007+0900 E/LOCKSCREEN(  845): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-03 01:47:07.007+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20002:APP_PAUSE
06-03 01:47:07.007+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:20002 event_info:0
06-03 01:47:07.007+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
06-03 01:47:07.007+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 01:47:07.017+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 01:47:07.017+0900 E/LOCKSCREEN(  845): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
06-03 01:47:07.017+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 01:47:07.037+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: MEM_FLUSH State: PAUSED
06-03 01:47:07.107+0900 W/LOCKSCREEN(  845): view-mgr.c: _event_route(130) > [_event_route:130:W] event:2 event_info:0
06-03 01:47:07.107+0900 E/LOCKSCREEN(  845): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-03 01:47:07.107+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 01:47:07.107+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-03 01:47:07.107+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-03 01:47:07.107+0900 E/LOCKSCREEN(  845): background-view.c: background_image_next_set(321) > [background_image_next_set:321:E] fopen wallpaper txt file failed.
06-03 01:47:07.227+0900 E/EFL     (10332): ecore_x<10332> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=132607218
06-03 01:47:07.387+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 10332 pgid = 10332
06-03 01:47:07.387+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(143) > dead_pid(10332)
06-03 01:47:07.387+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 01:47:07.417+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-03 01:47:07.417+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-03 01:47:07.417+0900 E/AUL_PAD ( 1359): launchpad.c: main(698) > error reading sigchld info
06-03 01:47:07.417+0900 I/Tizen::App( 1210): (243) > App[org.example.example] pid[10332] terminate event is forwarded
06-03 01:47:07.417+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 01:47:07.417+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [org.example.example, 10332, ]
06-03 01:47:07.417+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 01:47:07.417+0900 I/Tizen::App( 1210): (506) > TerminatedApp(org.example.example)
06-03 01:47:07.417+0900 I/Tizen::App( 1210): (512) > Not registered pid(10332)
06-03 01:47:07.417+0900 I/Tizen::System( 1210): (246) > Terminated app [org.example.example]
06-03 01:47:07.417+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 01:47:07.417+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 10332
06-03 01:47:07.427+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 10332
06-03 01:47:07.427+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 10332
06-03 01:47:07.427+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3519
06-03 01:47:07.437+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(10308) status(3)
06-03 01:47:07.437+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 01:47:07.437+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 01:47:07.437+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.tizen.crash-viewer(10308)
06-03 01:47:07.437+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 10308, appid: org.tizen.crash-viewer, status: fg
06-03 01:47:07.437+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(10308) status(0)
06-03 01:47:07.447+0900 E/RESOURCED(  653): datausage-common.c: app_terminated_cb(646) > No classid to terminate!
06-03 01:47:07.467+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 01:47:07.467+0900 I/APP_CORE(10308): appcore-efl.c: __do_app(514) > [APP 10308] Event: RESUME State: PAUSED
06-03 01:47:07.467+0900 I/CAPI_APPFW_APPLICATION(10308): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 01:47:07.467+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 01:47:07.467+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for org.example.example, 10332.
06-03 01:47:07.467+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 01:47:07.477+0900 I/Tizen::System( 1210): (259) > Active app [org.tizen.], current [org.exampl] 
06-03 01:47:07.477+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 01:47:07.507+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 01:47:07.507+0900 W/CRASH_MANAGER(10530): worker.c: worker_job(1199) > 1110332657861149642202
