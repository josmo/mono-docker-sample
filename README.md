[![Build Status](https://drone.seattleslow.com/api/badges/josmo/mono-docker-sample/status.svg)](https://drone.seattleslow.com/josmo/mono-docker-sample)

# mono-docker-sample

Super simple app, showing a micro C# service using mono, docker, rancher, drone io to build/deploy

## About

This is starting out as a quick POC for what complexities might come up.

You can see the service running on https://csharp.classis.io

it's using let's encrypt with lb encryption.

## Interesting TODO's

* [] Look at DB connections while keeping the service stateless - session level posible with REDIS or the likes?
* [] Look at the likes of RX.net for future async higher level functions
* [] Get sql server linux container version connections?
* [] More stuff I can' think of yet :)
