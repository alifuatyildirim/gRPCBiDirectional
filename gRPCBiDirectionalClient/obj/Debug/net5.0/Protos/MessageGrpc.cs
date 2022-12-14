// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/message.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcBiDirectionalClient {
  public static partial class Message
  {
    static readonly string __ServiceName = "message.Message";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::GrpcBiDirectionalClient.MessageRequest> __Marshaller_message_MessageRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcBiDirectionalClient.MessageRequest.Parser));
    static readonly grpc::Marshaller<global::GrpcBiDirectionalClient.MessageResponse> __Marshaller_message_MessageResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcBiDirectionalClient.MessageResponse.Parser));

    static readonly grpc::Method<global::GrpcBiDirectionalClient.MessageRequest, global::GrpcBiDirectionalClient.MessageResponse> __Method_GetMessage = new grpc::Method<global::GrpcBiDirectionalClient.MessageRequest, global::GrpcBiDirectionalClient.MessageResponse>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "GetMessage",
        __Marshaller_message_MessageRequest,
        __Marshaller_message_MessageResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcBiDirectionalClient.MessageReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for Message</summary>
    public partial class MessageClient : grpc::ClientBase<MessageClient>
    {
      /// <summary>Creates a new client for Message</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public MessageClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Message that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public MessageClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected MessageClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected MessageClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual grpc::AsyncDuplexStreamingCall<global::GrpcBiDirectionalClient.MessageRequest, global::GrpcBiDirectionalClient.MessageResponse> GetMessage(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetMessage(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::GrpcBiDirectionalClient.MessageRequest, global::GrpcBiDirectionalClient.MessageResponse> GetMessage(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_GetMessage, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override MessageClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new MessageClient(configuration);
      }
    }

  }
}
#endregion
