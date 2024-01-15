---
title: SqlServer 执行超大sql文件
author: 阿星𝑷𝒍𝒖𝒔
date: 2018-01-24 10:04:00
categories: Database
tags:
  - SqlServer
---

```sql
osql -S 127.0.0.1 -U sa -P 123456 -i d:\test.sql
```

osql 为 SQL Server 的命令，在 cmd 中执行该命令，一般安装完 SQL Server 后该命令对应的路径会自动添加到系统环境变量中

- S 表示要连接的数据库服务器
- U 表示登录的用户 ID
- P 表示登录密码
- i 表示要执行的脚本文件路径
