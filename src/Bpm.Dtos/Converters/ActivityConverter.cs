namespace BindOpen.Bpm.Activities
{
    /// <summary>
    /// This class represents a Xml helper.
    /// </summary>
    public static class ActivityConverter
    {
        /// <summary>
        /// Converts to DTO.
        /// </summary>
        /// <param key="poco">The poco to consider.</param>
        /// <returns>The DTO object.</returns>
        public static ActivityDto ToDto(this IBdoActivity poco)
        {
            if (poco == null) return null;

            ActivityDto dto = null;

            if (poco is IBdoWorkflow workflow)
            {
                dto = workflow.ToDto();
            }
            else if (poco is IBdoSequence sequence)
            {
                dto = sequence.ToDto();
            }
            else if (poco is IBdoTaskActivity task)
            {
                dto = task.ToDto();
            }

            return dto;
        }

        /// <summary>
        /// Converts to DTO.
        /// </summary>
        /// <param key="dto">The DTO to consider.</param>
        /// <returns>The DTO object.</returns>
        public static IBdoActivity ToPoco(
            this ActivityDto dto)
        {
            if (dto == null) return null;

            IBdoActivity poco = null;

            if (dto is WorkflowDto workflow)
            {
                poco = workflow.ToPoco();
            }
            else if (dto is SequenceDto sequence)
            {
                poco = sequence.ToPoco();
            }
            else if (dto is TaskActivityDto task)
            {
                poco = task.ToPoco();
            }

            return poco;
        }
    }
}
