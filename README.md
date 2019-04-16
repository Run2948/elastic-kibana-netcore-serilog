# [ASP.NET Core 利用 Docker、ElasticSearch、Kibana 来记录日志](https://www.cnblogs.com/Rwing/p/logging-with-elasticsearch-kibana-asp-net-core-and-docker.html)

### 1.[.NET CORE 项目指定使用的 SDK 版本](https://www.cnblogs.com/stulzq/p/9503121.html)
* 在项目的`根目录`打开cmd，执行命令即可：`dotnet new global.json --sdk-version <SDK版本号>`
* 要注意的是最后的参数是SDK版本，不是.NET Core 版本，可参照上表。
* 可在项目根目录执行命令来检查，看看是否与设置的SDK版本号一致：`dotnet --version`
* CLI 命令演示：
![NET CORE 项目指定使用的 SDK 版本演示](https://images2018.cnblogs.com/blog/668104/201808/668104-20180819225326017-661787224.gif)
* global.json 文件内容：
```
{
  "sdk": {
    "version": "2.1.300"
  }
}
```



