/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Returns properties of the user that you want to describe.
    /// </summary>
    public partial class DescribedUser
    {
        private string _arn;
        private string _homeDirectory;
        private List<HomeDirectoryMapEntry> _homeDirectoryMappings = new List<HomeDirectoryMapEntry>();
        private HomeDirectoryType _homeDirectoryType;
        private string _policy;
        private string _role;
        private List<SshPublicKey> _sshPublicKeys = new List<SshPublicKey>();
        private List<Tag> _tags = new List<Tag>();
        private string _userName;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// This property contains the unique Amazon Resource Name (ARN) for the user that was
        /// requested to be described.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=1600)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property HomeDirectory. 
        /// <para>
        /// This property specifies the landing directory (or folder), which is the location that
        /// files are written to or read from in an Amazon S3 bucket for the described user. An
        /// example is <code>/<i>your s3 bucket name</i>/home/<i>username</i> </code>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string HomeDirectory
        {
            get { return this._homeDirectory; }
            set { this._homeDirectory = value; }
        }

        // Check to see if HomeDirectory property is set
        internal bool IsSetHomeDirectory()
        {
            return this._homeDirectory != null;
        }

        /// <summary>
        /// Gets and sets the property HomeDirectoryMappings. 
        /// <para>
        /// Logical directory mappings that you specified for what S3 paths and keys should be
        /// visible to your user and how you want to make them visible. You will need to specify
        /// the "<code>Entry</code>" and "<code>Target</code>" pair, where <code>Entry</code>
        /// shows how the path is made visible and <code>Target</code> is the actual S3 path.
        /// If you only specify a target, it will be displayed as is. You will need to also make
        /// sure that your AWS IAM Role provides access to paths in <code>Target</code>.
        /// </para>
        ///  
        /// <para>
        /// In most cases, you can use this value instead of the scope down policy to lock your
        /// user down to the designated home directory ("chroot"). To do this, you can set <code>Entry</code>
        /// to '/' and set <code>Target</code> to the HomeDirectory parameter value. 
        /// </para>
        ///  
        /// <para>
        /// In most cases, you can use this value instead of the scope down policy to lock your
        /// user down to the designated home directory ("chroot"). To do this, you can set <code>Entry</code>
        /// to '/' and set <code>Target</code> to the HomeDirectory parameter value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<HomeDirectoryMapEntry> HomeDirectoryMappings
        {
            get { return this._homeDirectoryMappings; }
            set { this._homeDirectoryMappings = value; }
        }

        // Check to see if HomeDirectoryMappings property is set
        internal bool IsSetHomeDirectoryMappings()
        {
            return this._homeDirectoryMappings != null && this._homeDirectoryMappings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property HomeDirectoryType. 
        /// <para>
        /// The type of landing directory (folder) you mapped for your users' to see when they
        /// log into the SFTP server. If you set it to <code>PATH</code>, the user will see the
        /// absolute Amazon S3 bucket paths as is in their SFTP clients. If you set it <code>LOGICAL</code>,
        /// you will need to provide mappings in the <code>HomeDirectoryMappings</code> for how
        /// you want to make S3 paths visible to your user.
        /// </para>
        /// </summary>
        public HomeDirectoryType HomeDirectoryType
        {
            get { return this._homeDirectoryType; }
            set { this._homeDirectoryType = value; }
        }

        // Check to see if HomeDirectoryType property is set
        internal bool IsSetHomeDirectoryType()
        {
            return this._homeDirectoryType != null;
        }

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// Specifies the name of the policy in use for the described user.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this._policy != null;
        }

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// This property specifies the IAM role that controls your user's access to your Amazon
        /// S3 bucket. The policies attached to this role will determine the level of access you
        /// want to provide your users when transferring files into and out of your Amazon S3
        /// bucket or buckets. The IAM role should also contain a trust relationship that allows
        /// the SFTP server to access your resources when servicing your SFTP user's transfer
        /// requests.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
        }

        /// <summary>
        /// Gets and sets the property SshPublicKeys. 
        /// <para>
        /// This property contains the public key portion of the Secure Shell (SSH) keys stored
        /// for the described user.
        /// </para>
        /// </summary>
        [AWSProperty(Max=5)]
        public List<SshPublicKey> SshPublicKeys
        {
            get { return this._sshPublicKeys; }
            set { this._sshPublicKeys = value; }
        }

        // Check to see if SshPublicKeys property is set
        internal bool IsSetSshPublicKeys()
        {
            return this._sshPublicKeys != null && this._sshPublicKeys.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// This property contains the key-value pairs for the user requested. Tag can be used
        /// to search for and group users for a variety of purposes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// This property is the name of the user that was requested to be described. User names
        /// are used for authentication purposes. This is the string that will be used by your
        /// user when they log in to your SFTP server.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=32)]
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this._userName != null;
        }

    }
}