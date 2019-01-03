﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ERP_Dal
{
    public static class DBHelper
    {
        //获取web.config里的连接字符串
        public static string strCon = " Data Source=.;Initial Catalog=NewDB;Integrated Security=True";
        /// <summary>
        /// 增删改
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="str">连接字符串</param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql)
        {
            //实例化连接对象
            SqlConnection conn = new SqlConnection(strCon);
            int result = 0;
            try
            {
                conn.Open();
                //实例化命令对象
                SqlCommand cmd = new SqlCommand(sql, conn);
                //执行命令
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally {
                conn.Close();
            }
            return result;
        }
        public static DataTable GetData(string sql)
        {
            //实例化连接对象
            SqlConnection conn = new SqlConnection(strCon);
            DataTable dt = new DataTable();
           
            try
            {
                //实例化适配器
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                sda.Fill(dt);

            }
            catch (Exception)
            {
                
                throw;
            }
            return dt;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="str">连接字符串</param>
        /// <returns></returns>
        public static SqlDataReader GetDataReader(string sql)
        {
            //实例化连接对象
            SqlConnection conn = new SqlConnection(strCon);
            SqlDataReader sdr;
            try
            {
                conn.Open();
                //实例化命令对象
                SqlCommand cmd = new SqlCommand(sql, conn);
                sdr = cmd.ExecuteReader();

            }
            catch (Exception)
            {
                
                throw;
            }
            return sdr;
        }
      //
          //  HttpPostedFile file = context.Request.Files[0];
          //  string fileName = file.FileName;
          //  string path = context.Server.MapPath("../img/") + fileName;
          //  file.SaveAs(path);
          //  context.Response.Write(1);
        /// <summary>
        /// 返回单行单列
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="str">连接字符串</param>
        /// <returns></returns>
        public static int ExecuteScalar(string sql)
        {
            //实例化连接对象
            SqlConnection conn = new SqlConnection(strCon);
            int result = 0;
            try
            {
                conn.Open();
                //实例化命令对象
                SqlCommand cmd = new SqlCommand(sql, conn);
                result = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception)
            {

                throw;
            }
            finally {

                conn.Close();
            }
            return result;
        }
    }
}
//
//style="TEXT-DECORATION: none" 
