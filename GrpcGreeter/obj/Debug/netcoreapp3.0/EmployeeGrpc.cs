// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/Employee.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcEmployee {
  public static partial class Employee
  {
    static readonly string __ServiceName = "Employee";

    static readonly grpc::Marshaller<global::GrpcEmployee.EmpRequest> __Marshaller_EmpRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcEmployee.EmpRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcEmployee.EmpModel> __Marshaller_EmpModel = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcEmployee.EmpModel.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcEmployee.EmpRequest, global::GrpcEmployee.EmpModel> __Method_getInfo = new grpc::Method<global::GrpcEmployee.EmpRequest, global::GrpcEmployee.EmpModel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "getInfo",
        __Marshaller_EmpRequest,
        __Marshaller_EmpModel);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcEmployee.EmployeeReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Employee</summary>
    [grpc::BindServiceMethod(typeof(Employee), "BindService")]
    public abstract partial class EmployeeBase
    {
      public virtual global::System.Threading.Tasks.Task<global::GrpcEmployee.EmpModel> getInfo(global::GrpcEmployee.EmpRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(EmployeeBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_getInfo, serviceImpl.getInfo).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, EmployeeBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_getInfo, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcEmployee.EmpRequest, global::GrpcEmployee.EmpModel>(serviceImpl.getInfo));
    }

  }
}
#endregion