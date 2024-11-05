namespace RestfulWeb.Domain.Models
{
    public abstract class EntityAudit
    {
        /// <summary>
        /// 建立日期
        /// </summary>
        public DateTime CreatedDateTime { get; set; }

        /// <summary>
        /// 建立人員
        /// </summary>
        public int CreatedBy { get; set; }

        /// <summary>
        /// 更新日期
        /// </summary>
        public DateTime? UpdatedDateTime { get; set; }

        /// <summary>
        /// 更新人員
        /// </summary>
        public int? UpdatedBy { get; set; }

    }
}
