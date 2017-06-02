S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: example
PID: 9501
Date: 2017-06-03 01:40:28+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 9501, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x8000ca66
r2   = 0x8000ca66, r3   = 0x8001ff00
r4   = 0x8001b6dc, r5   = 0xbeb182a0
r6   = 0xb27eae61, r7   = 0xbeb180e8
r8   = 0x8001b6dc, r9   = 0xb5ee1708
r10  = 0xb80e7cb0, fp   = 0xbeb1827c
ip   = 0xb27fca68, sp   = 0xbeb18030
lr   = 0xb27eae8d, pc   = 0xb27eaef0
cpsr = 0x800f0030

Memory Information
MemTotal:   987012 KB
MemFree:     63380 KB
Buffers:     12708 KB
Cached:     106456 KB
VmPeak:     110064 KB
VmSize:     108580 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24184 KB
VmRSS:       24184 KB
VmData:      34512 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35728 KB
VmPTE:          82 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 9501 TID = 9501
9501 9504 9744 9745 

Maps Information
b12e3000 b1ae2000 rw-p [stack:9745]
b1b5e000 b1b66000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1b77000 b1b78000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1b88000 b1b9c000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1bb0000 b1bb1000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1bc1000 b1bc4000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1bd5000 b1bd6000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1be6000 b1be8000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1bf8000 b1bfa000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c0a000 b1c1a000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c2a000 b1c36000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c48000 b2447000 rw-p [stack:9744]
b2778000 b277f000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2790000 b2798000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b27a8000 b27bd000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b27cf000 b27d5000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27e5000 b27ed000 r-xp /opt/usr/apps/org.example.example/bin/example
b2945000 b2a28000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a5f000 b2a87000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a99000 b3298000 rw-p [stack:9504]
b3298000 b329a000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32aa000 b32b4000 r-xp /lib/libnss_files-2.20-2014.11.so
b32c5000 b32ce000 r-xp /lib/libnss_nis-2.20-2014.11.so
b32df000 b32f0000 r-xp /lib/libnsl-2.20-2014.11.so
b3303000 b3309000 r-xp /lib/libnss_compat-2.20-2014.11.so
b331a000 b331b000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3343000 b334a000 r-xp /usr/lib/libminizip.so.1.0.0
b335a000 b335f000 r-xp /usr/lib/libstorage.so.0.1
b336f000 b33ce000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b33e4000 b33f8000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3408000 b344c000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b345c000 b3464000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3474000 b34a4000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b34b7000 b3570000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3584000 b35d7000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b35e8000 b3603000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3613000 b36d4000 r-xp /usr/lib/libprotobuf.so.9.0.1
b36e7000 b36f7000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3707000 b3714000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3725000 b372c000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b373c000 b377d000 r-xp /usr/lib/libmdm.so.1.2.12
b378d000 b3795000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37a4000 b37b4000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37d5000 b3835000 r-xp /usr/lib/libasound.so.2.0.0
b3847000 b384a000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b385a000 b385d000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b386d000 b3872000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3882000 b3883000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3893000 b389e000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38b2000 b38b9000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38c9000 b38cf000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b38df000 b38e4000 r-xp /usr/lib/libmmfsession.so.0.0.1
b38f4000 b390f000 r-xp /usr/lib/libmmfsound.so.0.1.0
b391f000 b3926000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3936000 b3939000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b394a000 b3978000 r-xp /usr/lib/libidn.so.11.5.44
b3988000 b399e000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39af000 b39b9000 r-xp /usr/lib/libcares.so.2.1.0
b39c9000 b39d3000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b39e3000 b39e5000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b39f5000 b39f6000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a06000 b3a0a000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a1b000 b3a43000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a54000 b3a7d000 r-xp /usr/lib/libturbojpeg.so
b3a9d000 b3aa3000 r-xp /usr/lib/libgif.so.4.1.6
b3ab3000 b3af9000 r-xp /usr/lib/libcurl.so.4.3.0
b3b0a000 b3b2b000 r-xp /usr/lib/libexif.so.12.3.3
b3b46000 b3b5b000 r-xp /usr/lib/libtts.so
b3b6c000 b3b74000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b84000 b3c4a000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c6a000 b3d62000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d81000 b3e4f000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e66000 b3e68000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e78000 b3e7e000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e8e000 b3eb1000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3ec2000 b3ec4000 r-xp /usr/lib/libappsvc.so.0.1.0
b3ed4000 b3ed6000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3ee7000 b3eec000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f03000 b3f05000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f15000 b3f1c000 r-xp /usr/lib/libsensord-share.so
b3f2c000 b3f44000 r-xp /usr/lib/libsensor.so.1.1.0
b3f55000 b3f58000 r-xp /usr/lib/libXv.so.1.0.0
b3f68000 b3f6d000 r-xp /usr/lib/libutilX.so.1.1.0
b3f7d000 b3f82000 r-xp /usr/lib/libappcore-common.so.1.1
b3f92000 b3f99000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3fac000 b3fb0000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3fc1000 b409f000 r-xp /usr/lib/libCOREGL.so.4.0
b40bf000 b40c2000 r-xp /usr/lib/libuuid.so.1.3.0
b40d2000 b40e9000 r-xp /usr/lib/libblkid.so.1.1.0
b40fa000 b40fc000 r-xp /usr/lib/libXau.so.6.0.0
b410c000 b4153000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4165000 b416b000 r-xp /usr/lib/libjson-c.so.2.0.1
b417c000 b4180000 r-xp /usr/lib/libogg.so.0.7.1
b4190000 b41b2000 r-xp /usr/lib/libvorbis.so.0.4.3
b41c2000 b42a6000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42c2000 b42c5000 r-xp /usr/lib/libEGL.so.1.4
b42d6000 b42dc000 r-xp /usr/lib/libxcb-render.so.0.0.0
b42ec000 b42ee000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b42fe000 b430b000 r-xp /usr/lib/libGLESv2.so.2.0
b431c000 b437e000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4393000 b43ab000 r-xp /usr/lib/libmount.so.1.1.0
b43bd000 b43d1000 r-xp /usr/lib/libxcb.so.1.1.0
b43e1000 b43e8000 r-xp /lib/libcrypt-2.20-2014.11.so
b4420000 b4422000 r-xp /usr/lib/libiri.so
b4432000 b443d000 r-xp /usr/lib/libgpg-error.so.0.15.0
b444e000 b4484000 r-xp /usr/lib/libpulse.so.0.16.2
b4495000 b44d8000 r-xp /usr/lib/libsndfile.so.1.0.25
b44ed000 b4502000 r-xp /lib/libexpat.so.1.5.2
b4514000 b45d2000 r-xp /usr/lib/libcairo.so.2.11200.14
b45e6000 b45ee000 r-xp /usr/lib/libdrm.so.2.4.0
b45fe000 b4601000 r-xp /usr/lib/libdri2.so.0.0.0
b4611000 b465f000 r-xp /usr/lib/libssl.so.1.0.0
b4674000 b4680000 r-xp /usr/lib/libeeze.so.1.13.0
b4691000 b469a000 r-xp /usr/lib/libethumb.so.1.13.0
b46aa000 b46ad000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46bd000 b4874000 r-xp /usr/lib/libcrypto.so.1.0.0
b565f000 b5668000 r-xp /usr/lib/libXi.so.6.1.0
b5678000 b567a000 r-xp /usr/lib/libXgesture.so.7.0.0
b568a000 b568e000 r-xp /usr/lib/libXtst.so.6.1.0
b569e000 b56a4000 r-xp /usr/lib/libXrender.so.1.3.0
b56b4000 b56ba000 r-xp /usr/lib/libXrandr.so.2.2.0
b56ca000 b56cc000 r-xp /usr/lib/libXinerama.so.1.0.0
b56dd000 b56e0000 r-xp /usr/lib/libXfixes.so.3.1.0
b56f0000 b56fb000 r-xp /usr/lib/libXext.so.6.4.0
b570b000 b570d000 r-xp /usr/lib/libXdamage.so.1.1.0
b571d000 b571f000 r-xp /usr/lib/libXcomposite.so.1.0.0
b572f000 b5811000 r-xp /usr/lib/libX11.so.6.3.0
b5825000 b582c000 r-xp /usr/lib/libXcursor.so.1.0.2
b583c000 b5854000 r-xp /usr/lib/libudev.so.1.6.0
b5856000 b5859000 r-xp /lib/libattr.so.1.1.0
b5869000 b5889000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b588a000 b588f000 r-xp /usr/lib/libffi.so.6.0.2
b58a0000 b58b8000 r-xp /lib/libz.so.1.2.8
b58c8000 b58ca000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58da000 b59af000 r-xp /usr/lib/libxml2.so.2.9.2
b59c4000 b5a5f000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a7b000 b5a7e000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a8e000 b5aa7000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5ab8000 b5ac9000 r-xp /lib/libresolv-2.20-2014.11.so
b5add000 b5b57000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b6c000 b5b6e000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b7e000 b5b85000 r-xp /usr/lib/libembryo.so.1.13.0
b5b95000 b5b9f000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5bb0000 b5bc8000 r-xp /usr/lib/libpng12.so.0.50.0
b5bd9000 b5bfc000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c1d000 b5c31000 r-xp /usr/lib/libector.so.1.13.0
b5c42000 b5c5a000 r-xp /usr/lib/liblua-5.1.so
b5c6b000 b5cc2000 r-xp /usr/lib/libfreetype.so.6.11.3
b5cd6000 b5cfe000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d0f000 b5d22000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d33000 b5d6d000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d7e000 b5d8c000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d9c000 b5da4000 r-xp /usr/lib/libtbm.so.1.0.0
b5db4000 b5dc1000 r-xp /usr/lib/libeio.so.1.13.0
b5dd1000 b5dd3000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5de3000 b5de8000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5df8000 b5e0f000 r-xp /usr/lib/libefreet.so.1.13.0
b5e21000 b5e41000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e51000 b5e71000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e73000 b5e79000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e89000 b5e9a000 r-xp /usr/lib/libemotion.so.1.13.0
b5eab000 b5eb2000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ec2000 b5ed1000 r-xp /usr/lib/libeo.so.1.13.0
b5ee2000 b5ef4000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f05000 b5f0a000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f1a000 b5f33000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f43000 b5f60000 r-xp /usr/lib/libeet.so.1.13.0
b5f79000 b5fc1000 r-xp /usr/lib/libeina.so.1.13.0
b5fd2000 b5fe2000 r-xp /usr/lib/libefl.so.1.13.0
b5ff3000 b60d8000 r-xp /usr/lib/libicuuc.so.51.1
b60f5000 b6235000 r-xp /usr/lib/libicui18n.so.51.1
b624c000 b6284000 r-xp /usr/lib/libecore_x.so.1.13.0
b6296000 b6299000 r-xp /lib/libcap.so.2.21
b62a9000 b62d2000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62e3000 b62ea000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62fc000 b6333000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6344000 b642f000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6442000 b64bb000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64cd000 b64d2000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64e2000 b64ec000 r-xp /usr/lib/libvconf.so.0.2.45
b64fc000 b64fe000 r-xp /usr/lib/libvasum.so.0.3.1
b650e000 b6510000 r-xp /usr/lib/libttrace.so.1.1
b6520000 b6523000 r-xp /usr/lib/libiniparser.so.0
b6533000 b6559000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6569000 b656e000 r-xp /usr/lib/libxdgmime.so.1.1.0
b657f000 b6596000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65a7000 b6612000 r-xp /lib/libm-2.20-2014.11.so
b6623000 b6629000 r-xp /lib/librt-2.20-2014.11.so
b663a000 b6647000 r-xp /usr/lib/libunwind.so.8.0.1
b667d000 b67a1000 r-xp /lib/libc-2.20-2014.11.so
b67b6000 b67cf000 r-xp /lib/libgcc_s-4.9.so.1
b67df000 b68c1000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68d2000 b68fc000 r-xp /usr/lib/libdbus-1.so.3.8.12
b690d000 b6949000 r-xp /usr/lib/libsystemd.so.0.4.0
b694b000 b69ce000 r-xp /usr/lib/libedje.so.1.13.0
b69e1000 b69ff000 r-xp /usr/lib/libecore.so.1.13.0
b6a1f000 b6ba6000 r-xp /usr/lib/libevas.so.1.13.0
b6bdb000 b6bef000 r-xp /lib/libpthread-2.20-2014.11.so
b6c03000 b6e37000 r-xp /usr/lib/libelementary.so.1.13.0
b6e66000 b6e6a000 r-xp /usr/lib/libsmack.so.1.0.0
b6e7a000 b6e81000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e91000 b6e93000 r-xp /usr/lib/libdlog.so.0.0.0
b6ea3000 b6ea6000 r-xp /usr/lib/libbundle.so.0.1.22
b6eb6000 b6eb8000 r-xp /lib/libdl-2.20-2014.11.so
b6ec9000 b6ee1000 r-xp /usr/lib/libaul.so.0.1.0
b6ef5000 b6efa000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f0b000 b6f18000 r-xp /usr/lib/liblptcp.so
b6f2a000 b6f2e000 r-xp /usr/lib/libsys-assert.so
b6f3f000 b6f5f000 r-xp /lib/ld-2.20-2014.11.so
b6f70000 b6f75000 r-xp /usr/bin/launchpad-loader
b7e7d000 b8136000 rw-p [heap]
beaf8000 beb19000 rw-p [stack]
beaf8000 beb19000 rw-p [stack]
End of Maps Information

Callstack Information (PID:9501)
Call Stack Count: 19
 0: create_button_view + 0x1b (0xb27eaef0) [/opt/usr/apps/org.example.example/bin/example] + 0x5ef0
 1: setting_view_cb + 0x2c (0xb27eae8d) [/opt/usr/apps/org.example.example/bin/example] + 0x5e8d
 2: (0xb6a54175) [/usr/lib/libevas.so.1] + 0x35175
 3: (0xb5ecd219) [/usr/lib/libeo.so.1] + 0xb219
 4: eo_event_callback_call + 0x68 (0xb5ecbfb9) [/usr/lib/libeo.so.1] + 0x9fb9
 5: (0xb6a54515) [/usr/lib/libevas.so.1] + 0x35515
 6: (0xb6a5c725) [/usr/lib/libevas.so.1] + 0x3d725
 7: evas_canvas_event_feed_mouse_down + 0x6a (0xb6a61f6b) [/usr/lib/libevas.so.1] + 0x42f6b
 8: evas_event_feed_mouse_down + 0x30 (0xb6a65939) [/usr/lib/libevas.so.1] + 0x46939
 9: (0xb46ac173) [/usr/lib/libecore_input_evas.so.1] + 0x2173
10: (0xb69ecc4b) [/usr/lib/libecore.so.1] + 0xbc4b
11: (0xb69f2a5d) [/usr/lib/libecore.so.1] + 0x11a5d
12: ecore_main_loop_begin + 0x3e (0xb69f2c83) [/usr/lib/libecore.so.1] + 0x11c83
13: appcore_efl_main + 0x20c (0xb6ef82bd) [/usr/lib/libappcore-efl.so.1] + 0x32bd
14: ui_app_main + 0xc0 (0xb3fae909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
15: main + 0x10e (0xb27ea677) [/opt/usr/apps/org.example.example/bin/example] + 0x5677
16: (0xb6f71bb5) [/opt/usr/apps/org.example.example/bin/example] + 0x1bb5
17: __libc_start_main + 0x114 (0xb66934bc) [/lib/libc.so.6] + 0x164bc
18: (0xb6f71eb4) [/opt/usr/apps/org.example.example/bin/example] + 0x1eb4
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
/usr/apps/org.example.example)
06-03 01:40:21.972+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:40:21.972+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:40:21.972+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:40:21.972+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:40:21.982+0900 I/Tizen::App( 1210): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.example]
06-03 01:40:21.992+0900 I/Tizen::App( 1210): (416) > appName = [example]
06-03 01:40:21.992+0900 I/Tizen::App( 1210): (509) > exe = [/opt/usr/apps/org.example.example/bin/example], displayName = [forpet], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-03 01:40:21.992+0900 E/PKGMGR_INFO( 1210): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
06-03 01:40:21.992+0900 I/Tizen::App( 1210): (683) > Application count(1) in this package
06-03 01:40:21.992+0900 I/Tizen::App( 1210): (840) > Enter.
06-03 01:40:22.002+0900 I/Tizen::App( 1210): (416) > appName = [example]
06-03 01:40:22.002+0900 I/Tizen::App( 1210): (509) > exe = [/opt/usr/apps/org.example.example/bin/example], displayName = [forpet], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-03 01:40:22.002+0900 I/Tizen::App( 1210): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.example.info]
06-03 01:40:22.002+0900 I/Tizen::App( 1210): (131) > Enter
06-03 01:40:22.002+0900 I/Tizen::App( 1210): (137) > org.example.example does not have launch condition
06-03 01:40:22.002+0900 I/Tizen::App( 1210): (883) > Exit.
06-03 01:40:22.012+0900 I/Tizen::App( 1210): (703) > Exit.
06-03 01:40:22.012+0900 I/Tizen::App( 1210): (1584) > Package = [org.example.example], Key = [end], Value = [ok], install = [1]
06-03 01:40:22.012+0900 W/ISF_PANEL_EFL(  768): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
06-03 01:40:22.012+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.example]
06-03 01:40:22.012+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.example]
06-03 01:40:22.012+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
06-03 01:40:22.012+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
06-03 01:40:22.012+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.example]
06-03 01:40:22.022+0900 E/PKGMGR_SERVER( 9672): pkgmgr-server.c: sighandler(417) > child NORMAL exit [9675]
06-03 01:40:22.022+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[forpet] enable[1] system[0]
06-03 01:40:22.022+0900 E/HOME_APPS(  860): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.example] mdm is not enabled
06-03 01:40:22.032+0900 E/cluster-home(  860): mainmenu-data-manager.cpp: GetBoxDataByAppId(2539) >  cannot find box with appid[org.example.example]
06-03 01:40:22.042+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[forpet] enable[1] system[0]
06-03 01:40:22.052+0900 E/util-view(  860): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
06-03 01:40:22.062+0900 E/util-view(  860): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
06-03 01:40:23.003+0900 E/PKGMGR_SERVER( 9672): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-03 01:40:23.003+0900 E/PKGMGR_SERVER( 9672): pkgmgr-server.c: main(2471) > package manager server terminated.
06-03 01:40:25.395+0900 W/LOCKSCREEN(  845): dbus.c: _dbus_message_recv_cb(143) > [_dbus_message_recv_cb:143:W] PRE_LCD_ON cause[powerkey] (status:1)
06-03 01:40:25.395+0900 W/LOCKSCREEN(  845): event.c: _lcd_on_cb(54) > [_lcd_on_cb:54:W] Dbus LCD on
06-03 01:40:25.395+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:30001:LCD_ON
06-03 01:40:25.395+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:30001 event_info:0
06-03 01:40:25.395+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:3
06-03 01:40:25.395+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] PAUSE => WILL RESUME
06-03 01:40:25.405+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 01:40:25.405+0900 E/LOCKSCREEN(  845): control-panel-password.c: control_panel_password_update(136) > [control_panel_password_update:136:E] There is no control panel
06-03 01:40:25.455+0900 I/INDICATOR(  646): clock.c: indicator_clock_changed_cb(195) > ""
06-03 01:40:25.495+0900 E/UXT     (  646): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 1:40
06-03 01:40:25.495+0900 I/INDICATOR(  646): clock.c: getTimeFormatted(176) > "time format : 오전 1:40"
06-03 01:40:25.495+0900 I/INDICATOR(  646): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 1:40"
06-03 01:40:25.495+0900 W/INDICATOR(  646): clock.c: indicator_clock_changed_cb(272) > 
06-03 01:40:25.495+0900 I/INDICATOR(  646): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146726225 Time: <font_size=31> </font_size> <font_size=31> 오전 1:40</font_size></font>"
06-03 01:40:25.495+0900 I/INDICATOR(  646): battery.c: show_battery_icon(376) > "Percentage:(0) / Level:(9) / batt_Full:(0) / battery_charging(1)"
06-03 01:40:25.495+0900 E/INDICATOR(  646): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
06-03 01:40:25.495+0900 E/INDICATOR(  646): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-03 01:40:25.495+0900 E/INDICATOR(  646): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-03 01:40:25.495+0900 E/INDICATOR(  646): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-03 01:40:25.505+0900 E/INDICATOR(  646): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-03 01:40:25.505+0900 E/INDICATOR(  646): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-03 01:40:25.635+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:4
06-03 01:40:25.635+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL RESUME => RESUME
06-03 01:40:25.635+0900 W/APP_CORE(  845): appcore-efl.c: __cmsg_cb(1034) > LCD On. Resume the topmost app
06-03 01:40:25.635+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: RESUME State: PAUSED
06-03 01:40:25.635+0900 I/CAPI_APPFW_APPLICATION(  845): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 01:40:25.635+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20004:APP_RESUME
06-03 01:40:25.635+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:20004 event_info:0
06-03 01:40:25.635+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
06-03 01:40:25.635+0900 E/LOCKSCREEN(  845): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
06-03 01:40:25.635+0900 W/AUL     (  845): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.weather-m-agent)
06-03 01:40:25.635+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
06-03 01:40:25.645+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 845
06-03 01:40:25.645+0900 I/AUL_AMD (  610): amd_launch.c: __check_app_control_privilege(1830) > Skip the privilege check in case of preloaded apps
06-03 01:40:25.655+0900 W/AUL_AMD (  610): amd_launch.c: start_process(638) > child process: 9718
06-03 01:40:25.655+0900 E/RESOURCED(  653): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 01:40:25.705+0900 W/AUL_AMD (  610): amd_launch.c: __send_app_launch_signal(411) > send launch signal done: 9718
06-03 01:40:25.705+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 9718, appid: com.samsung.weather-m-agent
06-03 01:40:25.715+0900 I/Tizen::App( 1210): (499) > LaunchedApp(com.samsung.weather-m-agent)
06-03 01:40:25.715+0900 I/Tizen::App( 1210): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 9718.
06-03 01:40:25.725+0900 W/AUL     (  845): launch.c: app_request_to_launchpad(425) > request cmd(0) result(9718)
06-03 01:40:25.875+0900 E/weather-agent( 9718): AgentMain.cpp: AppControl(214) > [0;40;31mappId:com.samsung.lockscreen, portId:lockscreen-message-port, message:GET_DISPLAY_CITY_WEATHER_INFO[0;m
06-03 01:40:25.875+0900 E/weather-common( 9718): ShareTargetDBController.cpp: Insert(138) > [0;40;31mThere is a same appId. so we didn't insert this app[0;m
06-03 01:40:25.875+0900 E/weather-agent( 9718): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.lockscreen, PortID : lockscreen-message-port[0;m
06-03 01:40:25.875+0900 E/weather-agent( 9718): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.deco-app, PortID : lockscreen-message-port[0;m
06-03 01:40:25.885+0900 E/weather-common( 9718): CityDBController.cpp: GetPrimaryKey(376) > [0;40;31mNo result : 101[0;m
06-03 01:40:25.885+0900 E/weather-common( 9718): CityDBController.cpp: Select(265) > [0;40;31mNo result : 101[0;m
06-03 01:40:25.885+0900 E/weather-common( 9718): DBController.cpp: SelectDataWithPrimaryKey(154) > [0;40;31m[SelectDataWithPrimaryKey(): 154] (!cityPtr) [return][0;m
06-03 01:40:25.885+0900 E/weather-common( 9718): WeatherInformationShareUtil.cpp: ShareDisplayCityWeatherInfo(289) > [0;40;31mthere is no city[0;m
06-03 01:40:25.885+0900 E/weather-common( 9718): WeatherInformationShareUtil.cpp: AddWeatherInfoToBundle(438) > [0;40;31m[AddWeatherInfoToBundle(): 438] (cityPtrVector->size() == 0) [return][0;m
06-03 01:40:25.885+0900 I/MESSAGE_PORT( 9718): message-port.c: __initialize(872) > initialize
06-03 01:40:25.895+0900 I/MESSAGE_PORT( 9718): message-port.c: __initialize(878) > init : com.samsung.weather-m-agent
06-03 01:40:25.936+0900 I/MESSAGE_PORT( 9718): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-03 01:40:25.936+0900 I/MESSAGE_PORT( 9718): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-03 01:40:25.936+0900 I/MESSAGE_PORT( 9718): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 01:40:25.936+0900 I/MESSAGE_PORT( 9718): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.lockscreen:lockscreen-message-port]
06-03 01:40:25.936+0900 I/MESSAGE_PORT( 9718): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.lockscreen : com.samsung.weather-m-agent] 
06-03 01:40:25.936+0900 I/MESSAGE_PORT( 9718): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-03 01:40:25.936+0900 I/MESSAGE_PORT( 9718): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
06-03 01:40:25.936+0900 E/weather-common( 9718): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(613) > [0;40;31mmessage_port_send_message success [com.samsung.lockscreen, lockscreen-message-port][0;m
06-03 01:40:25.946+0900 I/MESSAGE_PORT(  845): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
06-03 01:40:25.946+0900 I/MESSAGE_PORT( 9718): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
06-03 01:40:25.946+0900 I/MESSAGE_PORT( 9718): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
06-03 01:40:25.946+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 01:40:25.946+0900 I/MESSAGE_PORT( 9718): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 01:40:25.946+0900 I/MESSAGE_PORT( 9718): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.deco-app:lockscreen-message-port]
06-03 01:40:25.946+0900 I/MESSAGE_PORT( 9718): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.deco-app : com.samsung.weather-m-agent] 
06-03 01:40:25.946+0900 I/MESSAGE_PORT( 9718): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
06-03 01:40:25.946+0900 E/MESSAGE_PORT( 9718): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0
06-03 01:40:25.946+0900 E/weather-common( 9718): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(631) > [0;40;31mmessage_port_send_message failed [com.samsung.deco-app, lockscreen-message-port][0;m
06-03 01:40:25.946+0900 I/MESSAGE_PORT( 9718): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-03 01:40:25.946+0900 I/MESSAGE_PORT( 9718): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-03 01:40:25.946+0900 I/MESSAGE_PORT( 9718): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 01:40:25.946+0900 I/MESSAGE_PORT( 9718): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
06-03 01:40:25.946+0900 I/MESSAGE_PORT( 9718): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
06-03 01:40:25.946+0900 I/MESSAGE_PORT( 9718): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-03 01:40:25.956+0900 E/MESSAGE_PORT( 9718): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
06-03 01:40:25.956+0900 E/weather-common( 9718): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
06-03 01:40:25.956+0900 I/MESSAGE_PORT( 9718): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-03 01:40:25.956+0900 I/MESSAGE_PORT( 9718): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-03 01:40:25.956+0900 I/MESSAGE_PORT( 9718): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 01:40:25.956+0900 I/MESSAGE_PORT( 9718): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
06-03 01:40:25.956+0900 I/MESSAGE_PORT( 9718): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
06-03 01:40:25.956+0900 I/MESSAGE_PORT( 9718): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-03 01:40:25.956+0900 I/MESSAGE_PORT( 9718): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-03 01:40:25.956+0900 I/MESSAGE_PORT( 9718): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-03 01:40:25.956+0900 I/MESSAGE_PORT( 9718): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-03 01:40:25.956+0900 I/MESSAGE_PORT( 9718): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 01:40:25.956+0900 I/MESSAGE_PORT( 9718): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
06-03 01:40:25.956+0900 I/MESSAGE_PORT( 9718): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
06-03 01:40:25.956+0900 I/MESSAGE_PORT( 9718): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-03 01:40:25.956+0900 I/MESSAGE_PORT( 1360): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
06-03 01:40:25.966+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 01:40:25.966+0900 E/MESSAGE_PORT( 9718): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
06-03 01:40:25.966+0900 E/weather-common( 9718): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
06-03 01:40:25.966+0900 E/weather-common( 9718): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 1[0;m
06-03 01:40:25.966+0900 E/weather-common( 9718): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 01:40:25.966+0900 E/weather-common( 9718): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : [0;m
06-03 01:40:25.966+0900 E/weather-common( 9718): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 01:40:25.966+0900 E/weather-common( 9718): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : [0;m
06-03 01:40:25.966+0900 E/weather-common( 9718): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 01:40:25.966+0900 E/weather-common( 9718): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : [0;m
06-03 01:40:25.966+0900 E/weather-common( 9718): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 01:40:25.966+0900 E/weather-common( 9718): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : [0;m
06-03 01:40:25.966+0900 E/weather-common( 9718): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 01:40:25.966+0900 E/weather-common( 9718): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : [0;m
06-03 01:40:25.966+0900 E/weather-common( 9718): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 01:40:25.966+0900 E/weather-common( 9718): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : [0;m
06-03 01:40:25.966+0900 E/weather-common( 9718): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 01:40:25.966+0900 E/weather-common( 9718): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : [0;m
06-03 01:40:25.966+0900 E/weather-common( 9718): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
06-03 01:40:25.966+0900 E/weather-common( 9718): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : Off[0;m
06-03 01:40:25.966+0900 E/weather-agent( 9718): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
06-03 01:40:25.966+0900 E/weather-agent( 9718): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
06-03 01:40:25.966+0900 I/MESSAGE_PORT( 9718): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
06-03 01:40:25.966+0900 I/MESSAGE_PORT( 9718): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-03 01:40:25.986+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 01:40:26.026+0900 I/Tizen::System( 1210): (280) > The screen has been turned on.
06-03 01:40:26.026+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 01:40:26.036+0900 E/GAME    ( 2577): .\..\src\TizenImpl.c: device_display_changed_cb(80) > device_display_changed_cb: state change to 0
06-03 01:40:26.046+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 01:40:26.056+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 01:40:26.056+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 01:40:26.056+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 01:40:26.056+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 01:40:26.056+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 01:40:26.066+0900 W/LOCKSCREEN(  845): dbus.c: _dbus_message_recv_cb(154) > [_dbus_message_recv_cb:154:W] POST_LCD_ON status 2 visibility(1)
06-03 01:40:26.066+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 01:40:26.076+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_update_cb(287) > received updating signal
06-03 01:40:26.076+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-03 01:40:26.076+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=132206072
06-03 01:40:26.086+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 01:40:26.086+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 01:40:26.086+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 01:40:26.086+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 01:40:26.086+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 01:40:26.086+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 01:40:26.096+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 01:40:26.096+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-03 01:40:26.096+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-03 01:40:26.096+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-03 01:40:26.096+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: fg
06-03 01:40:26.166+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=132206162
06-03 01:40:26.166+0900 E/LOCKSCREEN(  845): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
06-03 01:40:26.166+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80001:VIEW_GESTURED
06-03 01:40:26.166+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80001 event_info:0
06-03 01:40:26.166+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
06-03 01:40:26.166+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-03 01:40:26.166+0900 W/LOCKSCREEN(  845): view-mgr.c: _event_route(130) > [_event_route:130:W] event:80001 event_info:0
06-03 01:40:26.166+0900 W/LOCKSCREEN(  845): view-mgr.c: _state_transit(46) > [_state_transit:46:W] state transit:2
06-03 01:40:26.166+0900 W/LOCKSCREEN(  845): view-mgr.c: _state_transit(49) > [_state_transit:49:W] already in same state:2
06-03 01:40:26.166+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:4:LKD_EVT_WILL_UNLOCK
06-03 01:40:26.166+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:4 event_info:0
06-03 01:40:26.166+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event_delay(1041) > [lockd_event_delay:1041:W] dealyed event:2:UNLOCK wait for:0.330000
06-03 01:40:26.166+0900 E/LOCKSCREEN(  845): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-03 01:40:26.176+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 01:40:26.516+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:2 event_info:0
06-03 01:40:26.516+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:7
06-03 01:40:26.516+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] RESUME => HIDE
06-03 01:40:26.516+0900 E/LOCKSCREEN(  845): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
06-03 01:40:26.516+0900 E/LOCKSCREEN(  845): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-03 01:40:26.516+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 01:40:26.516+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-03 01:40:26.516+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-03 01:40:26.516+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
06-03 01:40:26.536+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 01:40:26.546+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
06-03 01:40:26.546+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 01:40:26.546+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
06-03 01:40:26.546+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 01:40:26.546+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(845) status(4)
06-03 01:40:26.546+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.lockscreen(845)
06-03 01:40:26.546+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 845, appid: com.samsung.lockscreen, status: bg
06-03 01:40:26.556+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
06-03 01:40:26.556+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 01:40:26.556+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 01:40:26.556+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
06-03 01:40:26.556+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
06-03 01:40:26.586+0900 I/Tizen::System( 1210): (259) > Active app [com.samsun], current [com.samsun] 
06-03 01:40:26.586+0900 I/Tizen::System( 1210): (273) > Current App[com.samsun] is already actived.
06-03 01:40:26.586+0900 W/LOCKSCREEN(  845): lockscreen.c: _window_visibility_cb(344) > [_window_visibility_cb:344:W] Window [0x2E00007] is [invisible]
06-03 01:40:26.586+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:10002:WIN_BECOME_INVISIBLE
06-03 01:40:26.586+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:10002 event_info:0
06-03 01:40:26.586+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 01:40:26.596+0900 E/LOCKSCREEN(  845): util-daemon.c: _lock_state_timer_cb(56) > [_lock_state_timer_cb:56:E] ########## LOCK STATE SET : VCONFKEY_IDLE_UNLOCK ##########
06-03 01:40:26.596+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: PAUSE State: RUNNING
06-03 01:40:26.596+0900 I/CAPI_APPFW_APPLICATION(  845): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 01:40:26.596+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 01:40:26.596+0900 E/LOCKSCREEN(  845): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-03 01:40:26.596+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20002:APP_PAUSE
06-03 01:40:26.596+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:20002 event_info:0
06-03 01:40:26.596+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
06-03 01:40:26.596+0900 E/LOCKSCREEN(  845): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
06-03 01:40:26.606+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: MEM_FLUSH State: PAUSED
06-03 01:40:26.656+0900 W/AUL     ( 9737): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.example)
06-03 01:40:26.656+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
06-03 01:40:26.676+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
06-03 01:40:26.686+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
06-03 01:40:26.686+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-03 01:40:26.686+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 9737
06-03 01:40:26.686+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-03 01:40:26.696+0900 E/RESOURCED(  653): block.c: block_prelaunch_state(134) > insert data org.example.example, table num : 9
06-03 01:40:26.696+0900 E/RESOURCED(  653): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 01:40:26.696+0900 W/LOCKSCREEN(  845): view-mgr.c: _event_route(130) > [_event_route:130:W] event:2 event_info:0
06-03 01:40:26.696+0900 E/LOCKSCREEN(  845): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-03 01:40:26.696+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 01:40:26.696+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-03 01:40:26.696+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-03 01:40:26.696+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
06-03 01:40:26.706+0900 W/AUL_PAD ( 1359): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-03 01:40:26.706+0900 W/AUL_PAD ( 1359): launchpad.c: __send_result_to_caller(267) > Check app launching
06-03 01:40:26.706+0900 E/LOCKSCREEN(  845): background-view.c: background_image_next_set(321) > [background_image_next_set:321:E] fopen wallpaper txt file failed.
06-03 01:40:26.726+0900 I/CAPI_APPFW_APPLICATION( 9501): app_main.c: ui_app_main(789) > app_efl_main
06-03 01:40:26.726+0900 I/CAPI_APPFW_APPLICATION( 9501): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-03 01:40:26.756+0900 E/TBM     ( 9501): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-03 01:40:26.796+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 9501, appid: org.example.example
06-03 01:40:26.796+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-03 01:40:26.806+0900 W/AUL     ( 9737): launch.c: app_request_to_launchpad(425) > request cmd(0) result(9501)
06-03 01:40:26.926+0900 I/APP_CORE( 9501): appcore-efl.c: __do_app(514) > [APP 9501] Event: RESET State: CREATED
06-03 01:40:26.926+0900 I/CAPI_APPFW_APPLICATION( 9501): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-03 01:40:26.926+0900 E/EFL     ( 9501): edje<9501> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 01:40:26.926+0900 E/EFL     ( 9501): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:40:26.937+0900 E/EFL     ( 9501): edje<9501> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 01:40:26.937+0900 E/EFL     ( 9501): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:40:26.937+0900 E/EFL     ( 9501): edje<9501> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 01:40:26.937+0900 E/EFL     ( 9501): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:40:26.937+0900 E/EFL     ( 9501): edje<9501> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 01:40:26.937+0900 E/EFL     ( 9501): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:40:26.937+0900 E/EFL     ( 9501): edje<9501> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 01:40:26.937+0900 E/EFL     ( 9501): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:40:26.957+0900 E/weather-agent( 9718): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
06-03 01:40:26.957+0900 I/CAPI_APPFW_APPLICATION( 9718): service_app_main.c: service_app_exit(446) > service_app_exit
06-03 01:40:26.967+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
06-03 01:40:26.967+0900 E/weather-agent( 9718): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
06-03 01:40:26.967+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
06-03 01:40:26.967+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 01:40:26.967+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 01:40:26.977+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 01:40:26.997+0900 I/Tizen::System( 1210): (259) > Active app [org.exampl], current [com.samsun] 
06-03 01:40:26.997+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 01:40:26.997+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 01:40:27.017+0900 W/APP_CORE( 9501): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5800002
06-03 01:40:27.017+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
06-03 01:40:27.097+0900 I/Tizen::Net::Wifi( 1210): (941) > The background scan result updated.
06-03 01:40:27.107+0900 W/AUL_AMD (  610): amd_request.c: __send_app_termination_signal(609) > send dead signal done
06-03 01:40:27.127+0900 I/Tizen::App( 1210): (243) > App[com.samsung.weather-m-agent] pid[9718] terminate event is forwarded
06-03 01:40:27.127+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: PAUSE State: RUNNING
06-03 01:40:27.127+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 01:40:27.127+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 01:40:27.127+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 9718, ]
06-03 01:40:27.127+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 01:40:27.127+0900 I/Tizen::App( 1210): (506) > TerminatedApp(com.samsung.weather-m-agent)
06-03 01:40:27.127+0900 I/Tizen::App( 1210): (512) > Not registered pid(9718)
06-03 01:40:27.137+0900 I/Tizen::System( 1210): (246) > Terminated app [com.samsung.weather-m-agent]
06-03 01:40:27.137+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 01:40:27.137+0900 E/cluster-home(  860): homescreen.cpp: OnPause(260) >  app pause
06-03 01:40:27.137+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 9718
06-03 01:40:27.137+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 9718
06-03 01:40:27.147+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(4)
06-03 01:40:27.147+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(860)
06-03 01:40:27.147+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: bg
06-03 01:40:27.147+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(9501) status(3)
06-03 01:40:27.147+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 01:40:27.147+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 01:40:27.147+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.example(9501)
06-03 01:40:27.147+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 9501, appid: org.example.example, status: fg
06-03 01:40:27.157+0900 E/weather-widget( 1360): Widget4x4Page.cpp: SetRefreshButton(72) > [0;40;31m[SetRefreshButton(): 72] (mCityLayout == NULL) [return][0;m
06-03 01:40:27.157+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-03 01:40:27.157+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-03 01:40:27.157+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: bg
06-03 01:40:27.157+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 01:40:27.157+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 9718.
06-03 01:40:27.167+0900 I/APP_CORE( 9501): appcore-efl.c: __do_app(514) > [APP 9501] Event: RESUME State: CREATED
06-03 01:40:27.187+0900 I/APP_CORE( 9501): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-03 01:40:27.187+0900 I/APP_CORE( 9501): appcore-efl.c: __do_app(625) > [APP 9501] Initial Launching, call the resume_cb
06-03 01:40:27.187+0900 I/CAPI_APPFW_APPLICATION( 9501): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 01:40:27.487+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(9501) status(0)
06-03 01:40:27.847+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3425
06-03 01:40:27.857+0900 I/Tizen::App( 1210): (499) > LaunchedApp(org.example.example)
06-03 01:40:27.857+0900 I/Tizen::App( 1210): (733) > Finished invoking application event listener for org.example.example, 9501.
06-03 01:40:28.188+0900 E/EFL     ( 9501): ecore_x<9501> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=132208190
06-03 01:40:28.348+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 9501 pgid = 9501
06-03 01:40:28.348+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(143) > dead_pid(9501)
06-03 01:40:28.348+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 01:40:28.358+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
06-03 01:40:28.358+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 01:40:28.358+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 01:40:28.368+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
06-03 01:40:28.368+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
06-03 01:40:28.398+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-03 01:40:28.398+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-03 01:40:28.398+0900 E/AUL_PAD ( 1359): launchpad.c: main(698) > error reading sigchld info
06-03 01:40:28.408+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 9501
06-03 01:40:28.408+0900 I/Tizen::App( 1210): (243) > App[org.example.example] pid[9501] terminate event is forwarded
06-03 01:40:28.408+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 01:40:28.408+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [org.example.example, 9501, ]
06-03 01:40:28.408+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 01:40:28.408+0900 I/Tizen::App( 1210): (506) > TerminatedApp(org.example.example)
06-03 01:40:28.408+0900 I/Tizen::App( 1210): (512) > Not registered pid(9501)
06-03 01:40:28.408+0900 I/Tizen::System( 1210): (246) > Terminated app [org.example.example]
06-03 01:40:28.408+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 01:40:28.418+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 9501
06-03 01:40:28.418+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 9501
06-03 01:40:28.418+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3426
06-03 01:40:28.428+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(0)
06-03 01:40:28.438+0900 E/RESOURCED(  653): datausage-common.c: app_terminated_cb(646) > No classid to terminate!
06-03 01:40:28.438+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 01:40:28.438+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for org.example.example, 9501.
06-03 01:40:28.448+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
06-03 01:40:28.448+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 01:40:28.448+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
06-03 01:40:28.448+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 01:40:28.468+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-03 01:40:28.488+0900 I/TIZEN_N_SOUND_MANAGER(  900): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
06-03 01:40:28.488+0900 E/TIZEN_N_SOUND_MANAGER(  900): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-03 01:40:28.488+0900 I/Tizen::System( 1210): (259) > Active app [com.samsun], current [org.exampl] 
06-03 01:40:28.488+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 01:40:28.488+0900 I/TIZEN_N_SOUND_MANAGER(  900): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
06-03 01:40:28.488+0900 E/TIZEN_N_SOUND_MANAGER(  900): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-03 01:40:28.498+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 01:40:28.498+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 01:40:28.498+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 01:40:28.498+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 01:40:28.498+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 01:40:28.498+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 01:40:28.508+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 01:40:28.528+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 01:40:28.528+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-03 01:40:28.528+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-03 01:40:28.528+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-03 01:40:28.528+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: fg
06-03 01:40:28.548+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 01:40:28.608+0900 W/CRASH_MANAGER( 9750): worker.c: worker_job(1199) > 1109501657861149642162
